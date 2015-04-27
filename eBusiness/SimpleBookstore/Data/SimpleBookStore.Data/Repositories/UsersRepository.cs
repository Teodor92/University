namespace SimpleBookStore.Data.Repositories
{
    using System;
    using System.Linq;

    using SimpleBookStore.Data.Models;
    using SimpleBookStore.Data.Repositories.Base;
    using SimpleBookStore.Data.Repositories.Contracts;

    public class UsersRepository : GenericRepository<User>, IUsersRepository
    {
        public UsersRepository(ISbsDbContext context)
            : base(context)
        {
        }

        public User GetByUsername(string username)
        {
            return this.All().FirstOrDefault(x => x.UserName == username);
        }

        public User GetById(string id)
        {
            return this.All().FirstOrDefault(x => x.Id == id);
        }

        public override void Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
