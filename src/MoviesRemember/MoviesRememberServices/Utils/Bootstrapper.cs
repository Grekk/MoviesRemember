using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using PetaPoco;
using MoviesRememberDomain;
using DefaultConnection;
using AutoMapper;
using MoviesRememberDao.Interface;
using MoviesRememberDao;

namespace MoviesRememberServices.Utils
{
    public static class Bootstrapper
    {
        private static void RegisterDependencies()
        {
            ObjectFactory.Initialize(
                x => x.Scan(
                    scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.WithDefaultConventions();
                        scan.LookForRegistries();   
                    }));

            ObjectFactory.Container.Configure(
                c => c.For<Database>().Use<DefaultConnectionDB>()
                );
            ObjectFactory.Container.Configure(
               c => c.For<AbstractUserMovieDAO>().Use<UserMovieDAO>()
               );

#if DEBUG
            // Place a breakpoint on the line and see the configuration of StructureMap.
            string configuration = ObjectFactory.WhatDoIHave();
#endif
        }

        private static void InitializeMapper()
        {
            Mapper.CreateMap<TinyMovie, user_movie>()
                .ForMember(dest => dest.user_movie_picture, opt => opt.MapFrom(src => src.PictureUrl))
                .ForMember(dest => dest.user_movie_release_date, opt => opt.MapFrom(src => DateTime.Parse(src.ReleaseDate)))
                .ForMember(dest => dest.user_movie_api_id, opt => opt.MapFrom(src => src.ApiId))
                .ForMember(dest => dest.user_movie_title, opt => opt.MapFrom(src => src.Title));

            Mapper.CreateMap<Movie, TinyMovie>();

            Mapper.CreateMap<user_movie, TinyMovie>()
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom(src => src.user_movie_picture))
                .ForMember(dest => dest.ReleaseDate, opt => opt.MapFrom(src => src.user_movie_release_date.ToShortDateString()))
                .ForMember(dest => dest.ApiId, opt => opt.MapFrom(src => src.user_movie_api_id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.user_movie_title));
        }

        public static void Bootstrap()
        {
            RegisterDependencies();
            InitializeMapper();
        }
    }
}
