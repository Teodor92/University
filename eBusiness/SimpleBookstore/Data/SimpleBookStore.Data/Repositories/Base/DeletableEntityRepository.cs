namespace OJS.Data.Repositories.Base
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Contracts;
    using SimpleBookStore.Data.Repositories.Base;

    public class DeletableEntityRepository<T> :
        GenericRepository<T>, IDeletableEntityRepository<T> where T : class, IDeletableEntity
    {
        public DeletableEntityRepository(ISbsDbContext context)
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

        public override void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void HardDelete(T entity)
        {
            base.Delete(entity);
        }
    }
}
