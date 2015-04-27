namespace SimpleBookStore.Data.Repositories.Contracts
{
    using SimpleBookStore.Data.Contracts;
    using SimpleBookStore.Data.Models;

    public interface IUsersRepository : IRepository<User>
    {
        User GetByUsername(string username);

        User GetById(string id);
    }
}
