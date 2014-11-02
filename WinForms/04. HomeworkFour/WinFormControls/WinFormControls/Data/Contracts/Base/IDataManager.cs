namespace WinFormControls.Data.Contracts.Base
{
    public interface IDataManager
    {
        ICurrencyRepository Currency { get; }

        INomenclatureRepository Nomenclatures { get; }
    }
}
