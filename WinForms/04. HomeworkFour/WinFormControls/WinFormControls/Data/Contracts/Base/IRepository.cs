namespace WinFormControls.Data.Contracts
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        IEnumerable<T> All();

        T Find(int id);
    }
}
