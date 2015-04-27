namespace SimpleBookStore.Data
{
    using System;

    using Microsoft.AspNet.Identity.EntityFramework;

    using SimpleBookStore.Data.Contracts;
    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Data.Repositories.Contracts;

    public interface ISbsData : IDisposable
    {
        IRepository<Book> Books { get; }

        IRepository<BookType> BookTypes { get; }

        IRepository<Guest> Guests { get; }

        IRepository<ShopingCartItem> ShopingCart { get; }

        IUsersRepository Users { get; }

        IRepository<IdentityRole> Roles { get; }

        ISbsDbContext Context { get; }

        int SaveChanges();
    }
}
