using System;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace PTIoC
{
    public class DependentInjectionControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public DependentInjectionControllerFactory(IKernel container)
        {
            _kernel = container;
        }

        public IKernel Kernel
        {
            get
            {
                return _kernel;
            }
        }

        protected override IController GetControllerInstance(Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(0x194,
                                        string.Format(CultureInfo.CurrentUICulture, @"未发现指定的 Controller {0}。",
                                                      RequestContext.HttpContext.Request.Path));
            }

            if (!typeof(Controller).IsAssignableFrom(controllerType))
                throw new ArgumentException(string.Format("Type requested is not a controller: {0}", controllerType.Name),
                                            "controllerType");

            var controller = _kernel.Get(controllerType) as Controller;
            controller.ActionInvoker = _kernel.Get<ControllerActionInvoker>();
            return controller;
        }
    }
}