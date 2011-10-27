using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using PTRepository;

namespace PTCore
{
    public class ControllerDependencyInjection
    {
        private readonly IKernel _kernel;

        public ControllerDependencyInjection()
        {
            _kernel = new StandardKernel(new RepositoryBindingModule(), new RepositoryBindingModule());
        }

        public IKernel Kernel
        {
            get { return _kernel; }
        }
    }
}
