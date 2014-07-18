namespace Slms.Data
{
    using System;
    using System.Collections.Generic;

    using Slms.Data.Contracts;
    using Slms.Data.Models;
    using Slms.Data.Repositories.Base;
    using Slms.Data.Repositories.Contracts;

    public class SlmsData : ISlmsData
    {
        private readonly ISlmsDbContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public SlmsData()
            : this(new SlmsDbContext())
        {
        }

        public SlmsData(ISlmsDbContext context)
        {
            this.context = context;
        }

        public ISlmsDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public IDeletableEntityRepository<Author> Authors
        {
            get
            {
                return this.GetDeletableEntityRepository<Author>();
            }
        }

        public IDeletableEntityRepository<Book> Books
        {
            get
            {
                return this.GetDeletableEntityRepository<Book>();
            }
        }

        public IDeletableEntityRepository<Tag> Tags
        {
            get
            {
                return this.GetDeletableEntityRepository<Tag>();
            }
        }

        public IDeletableEntityRepository<Category> Categories
        {
            get
            {
                return this.GetDeletableEntityRepository<Category>();
            }
        }

        public IDeletableEntityRepository<Country> Countries
        {
            get
            {
                return this.GetDeletableEntityRepository<Country>();
            }
        }

        public IDeletableEntityRepository<Publisher> Publishers
        {
            get
            {
                return this.GetDeletableEntityRepository<Publisher>();
            }
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

        private IDeletableEntityRepository<T> GetDeletableEntityRepository<T>() where T : class, IDeletableEntity
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(DeletableEntityRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IDeletableEntityRepository<T>)this.repositories[typeof(T)];
        }
    }
}
