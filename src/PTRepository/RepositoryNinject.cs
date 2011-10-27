using Ninject.Modules;
using PTDomain;

namespace PTRepository
{
    public class RepositoryBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBaseRepository<ShopContract>>().To<MongoRepository<ShopContract>>();
            Bind<IBaseRepository<ViewPointContract>>().To<MongoRepository<ViewPointContract>>();
        }
    }
}