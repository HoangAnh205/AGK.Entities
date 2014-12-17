using System.Web.Mvc;
using AGK.IServices;
using AGK.Service;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace AGK.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            //  Đăng kí các Service
            container.RegisterType<IProductService, ProductService>();
;            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}