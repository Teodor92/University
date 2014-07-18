namespace Slms.Data.Repositories.Base
{
    using System.Linq;
    using Slms.Data.Contracts;
    using Slms.Data.Repositories.Contracts;

    public class DeletableEntityRepository<T> : GenericRepository<T>, IDeletableEntityRepository<T> 
        where T : class, IDeletableEntity
    {
        public DeletableEntityRepository(ISlmsDbContext context)
            : base(context)
        {
        }

        public override IQueryable<T> All()
        {
            return base.All().Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return base.All();
        }
    }
}
