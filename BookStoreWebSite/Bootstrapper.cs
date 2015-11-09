using System;   
using System.Collections.Generic;   
using System.Linq;   
using System.Web;   
using System.Web.Mvc;   
using Microsoft.Practices.Unity;   
using Unity.Mvc5;
using BookStoreServiceApi;
using BookStoreWebSite.FakeServices;
using BookStoreWebSite.Controllers;


namespace BookStoreWebSite
{
    public class Bootstrapper   
    {   
        public static IUnityContainer Initialise()   
        {   
            var container = BuildUnityContainer();   
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));   
            return container;   
        }   
        private static IUnityContainer BuildUnityContainer()   
        {   
            var container = new UnityContainer();   
   
            // register all your components with the container here   
            //This is the important line to edit   
            container.RegisterType<IBookStoreService, FakeBookStoreService>();

            container.RegisterType<AccountController>(new InjectionConstructor(new object[] {typeof(IBookStoreService)}));
            //container.RegisterType<RolesAdminController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            //container.RegisterType<UsersAdminController>(new InjectionConstructor());

            RegisterTypes(container);   
            return container;   
        }   
        public static void RegisterTypes(IUnityContainer container)   
        {   
   
        }   
    }   

}