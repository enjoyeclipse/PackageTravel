using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Mvc;
using PTIoC;

namespace PTCore
{
    public class ControllerConfigMachine
    {
        public static void ConfigureDependencies()
        {
            var controllerFactory = new DependentInjectionControllerFactory(
                new ControllerDependencyInjection().Kernel);

            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            //预先绑顶Controlller,保证线程安全
            foreach (Type type in Assembly.GetExecutingAssembly().GetExportedTypes().Where(IsController))
                controllerFactory.Kernel.Bind(type).ToSelf();
        }


        private static bool IsController(Type type)
        {
            return typeof(IController).IsAssignableFrom(type) && type.IsPublic && !type.IsAbstract && !type.IsInterface;
        }
    }
}
