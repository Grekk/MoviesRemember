using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMap;

namespace MoviesRememberClient.Registry
{
    public class StructureMapDependencyResolver : IDependencyResolver
    {
        #region Implementation of IDependencyResolver

        /// <summary>
        /// Resolves singly registered services that support arbitrary object creation.
        /// </summary>
        /// <returns>
        /// The requested service or object.
        /// </returns>
        /// <param name="serviceType">The type of the requested service or object.</param>
        public object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                return null;
            }

            try
            {
                return ObjectFactory.GetInstance(serviceType);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Resolves multiply registered services.
        /// </summary>
        /// <returns>
        /// The requested services.
        /// </returns>
        /// <param name="serviceType">The type of the requested services.</param>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ObjectFactory.GetAllInstances(serviceType).Cast<object>();
        }

        #endregion
    }
}