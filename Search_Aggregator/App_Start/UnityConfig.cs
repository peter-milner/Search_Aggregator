using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Search_Aggregator.Services;
using System.Collections.Generic;

namespace Search_Aggregator
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ISearchService, GoogleSearchService>("A");
            container.RegisterType<ISearchService, BingSearchService>("B");
            container.RegisterType<IEnumerable<ISearchService>,ISearchService[]>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}