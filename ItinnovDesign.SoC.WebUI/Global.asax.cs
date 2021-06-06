using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Web;

namespace ItinnovDesign.SoC.WebUI
{
    public class Global : HttpApplication, Autofac.Integration.Web.IContainerProviderAccessor
    {
        // Provider that holds the application container.
        static Autofac.Integration.Web.IContainerProvider _containerProvider;

        // Instance property that will be used by Autofac HttpModules
        // to resolve and inject dependencies.
        public Autofac.Integration.Web.IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

       
        void Application_Start(object sender, EventArgs e)
        {
            // Build up your application container and register your dependencies.
            var builder = new Autofac.ContainerBuilder();
            // builder.RegisterType<Model.IProductRepository>();
            builder.RegisterType<Repository.ProductRepository>().As<Model.IProductRepository>().InstancePerRequest();
            builder.RegisterType<Model.ProductService>();
            builder.RegisterType<Service.ProductService>();
           
            // ... continue registering dependencies...

            // Once you're done registering things, set the container
            // provider up with your registrations.
            // _containerProvider = new Autofac.Integration.Web.ContainerProvider(builder.Build());
            _containerProvider = new Autofac.Integration.Web.ContainerProvider(builder.Build());
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}