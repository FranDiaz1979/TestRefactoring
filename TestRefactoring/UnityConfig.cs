using System;
using System.Collections.Generic;
using System.Text;
using TestRefactoring.BusinessLogic;
using Unity;

namespace TestRefactoring
{
    internal static class UnityConfig
    {
        public static UnityContainer Register()
        {
            var container = new UnityContainer();
            container.RegisterType<ITrabajadorService, TrabajadorService>();
            return container;
        }
    }
}
