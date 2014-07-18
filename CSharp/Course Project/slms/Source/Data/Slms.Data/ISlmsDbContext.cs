namespace Slms.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Slms.Data.Models;

    public interface ISlmsDbContext : IDisposable
    {
        IDbSet<Author> Authors { get; set; }

        IDbSet<Book> Books { get; set; }

        IDbSet<Tag> Tags { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Publisher> Publishers { get; set; }

        DbContext DbContext { get; }

        int SaveChanges();

        void ClearDatabase();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
