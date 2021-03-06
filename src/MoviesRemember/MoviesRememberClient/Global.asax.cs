﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MoviesRememberClient.Registry;
using StructureMap;
using System.Configuration;

namespace MoviesRememberClient
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Showing", action = "WeekMovies", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            InitializeContainer();

            Bundle shared = new Bundle("~/Content/Shared/css", new CssMinify());
            shared.AddFile("~/Content/Shared/useraction.css");


            BundleTable.Bundles.Add(shared);
            BundleTable.Bundles.RegisterTemplateBundles();
            Bundle bundle = BundleTable.Bundles.Where(x => x.Path == "~/Scripts/js").Single();
            bundle.AddFile("~/Scripts/jquery.paging.min.js");
        }

        private void InitializeContainer()
        {
            Bootstrapper.Bootstrap();
            StructureMapDependencyResolver structureMapDependencyResolver = new StructureMapDependencyResolver();
            DependencyResolver.SetResolver(structureMapDependencyResolver);
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
        }

    }
}