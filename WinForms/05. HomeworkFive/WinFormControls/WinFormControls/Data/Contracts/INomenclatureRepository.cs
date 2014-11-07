namespace WinFormControls.Data.Contracts
{
    using WinFormControls.Models;

    public interface INomenclatureRepository : IRepository<Nomenclature>
    {
        Nomenclature GetByName(string name);
    }
}
