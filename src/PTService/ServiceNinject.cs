using Ninject.Modules;
using PTService;

namespace PTRepository
{
    public class RepositoryBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<PackageBuilder>().ToSelf().InSingletonScope();
        }
    }
}