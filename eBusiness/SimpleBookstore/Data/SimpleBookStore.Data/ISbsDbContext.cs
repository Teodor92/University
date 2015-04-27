namespace SimpleBookStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using SimpleBookStore.Data.Models;

    public interface ISbsDbContext : IDisposable
    {
        IDbSet<Book> Books { get; set; }

        IDbSet<BookType> BookTypes { get; set; }

        IDbSet<Guest> Guests { get; set; }

        IDbSet<ShopingCartItem> ShopingCart { get; set; }

        DbContext DbContext { get; }

        int SaveChanges();

        void ClearDatabase();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
