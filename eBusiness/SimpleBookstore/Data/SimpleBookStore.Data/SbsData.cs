namespace SimpleBookStore.Data
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNet.Identity.EntityFramework;

    using OJS.Data.Repositories.Base;

    using SimpleBookStore.Data.Contracts;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Data.Repositories;
    using SimpleBookStore.Data.Repositories.Base;
    using SimpleBookStore.Data.Repositories.Contracts;

    public class SbsData : ISbsData
    {
        private readonly ISbsDbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public SbsData()
            : this(new SbsDbContext())
        {
        }

        public SbsData(ISbsDbContext context)
        {
            this.context = context;
        }

        public IRepository<Book> Books
        {
            get { return this.GetRepository<Book>(); }
        }

        public IRepository<BookType> BookTypes
        {
            get { return this.GetRepository<BookType>(); }
        }

        public IRepository<Guest> Guests
        {
            get { return this.GetRepository<Guest>(); }
        }

        public IRepository<ShopingCartItem> ShopingCart
        {
            get { return this.GetRepository<ShopingCartItem>(); }
        }

        public IUsersRepository Users
        {
            get
            {
                return (UsersRepository)this.GetRepository<User>();
            }
        }

        public IRepository<IdentityRole> Roles
        {
            get
            {
                return this.GetRepository<IdentityRole>();
            }
        }

        public ISbsDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The number of objects written to the underlying database.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                if (typeof(T).IsAssignableFrom(typeof(User)))
                {
                    type = typeof(UsersRepository);
                }

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
