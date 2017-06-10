[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(_2011600136.MVC.App_Start.NinjectWeb), "Start")]

namespace _2011600136.MVC.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject.Web;

    public static class NinjectWeb 
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}
