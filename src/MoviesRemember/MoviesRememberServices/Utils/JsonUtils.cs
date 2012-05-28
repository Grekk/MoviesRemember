using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using MoviesRememberDomain;

namespace MoviesRememberServices.Utils
{
    public static class JsonUtils
    {
        public static string GetJson(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));

                    StreamReader loResponseStream = new StreamReader(response.GetResponseStream());
                    return loResponseStream.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static TinyMovie GetTinyMovie(dynamic jsonMovie)
        {
            TinyMovie movie = new TinyMovie();
            movie.Id = long.Parse(jsonMovie["code"].ToString());
            movie.PictureUrl = (jsonMovie["poster"])["href"];
            movie.Title = jsonMovie["title"];
            movie.OriginalTitle = jsonMovie["originalTitle"];
            return movie;
        }
    }
}
