namespace Slms.Data
{
    using System;

    using Slms.Data.Models;
    using Slms.Data.Repositories.Contracts;

    public interface ISlmsData : IDisposable
    {
        ISlmsDbContext Context { get; }

        IDeletableEntityRepository<Author> Authors { get; }

        IDeletableEntityRepository<Book> Books { get; }

        IDeletableEntityRepository<Tag> Tags { get; }

        IDeletableEntityRepository<Category> Categories { get; }

        IDeletableEntityRepository<Country> Countries { get; }

        IDeletableEntityRepository<Publisher> Publishers { get; }

        int SaveChanges();
    }
}
