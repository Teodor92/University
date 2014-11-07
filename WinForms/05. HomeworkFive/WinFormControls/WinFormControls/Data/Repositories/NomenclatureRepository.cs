namespace WinFormControls.Provider
{
    using System.Collections.Generic;
    using System.Linq;
    using WinFormControls.Data.Contracts;
    using WinFormControls.Models;

    public class NomenclatureRepository : INomenclatureRepository
    {
        private readonly IEnumerable<Nomenclature> sampleNomenclatures;

        public NomenclatureRepository(IEnumerable<Nomenclature> items = null)
        {
            this.sampleNomenclatures = items;
        }

        public IEnumerable<Nomenclature> GetItems()
        {
            return this.sampleNomenclatures;
        }

        public decimal GetPriceForItem(string itemName)
        {
            return this.sampleNomenclatures
                .Where(x => x.Name == itemName)
                .Select(x => x.Price)
                .FirstOrDefault();
        }

        public IEnumerable<Nomenclature> All()
        {
            return this.sampleNomenclatures;
        }

        public Nomenclature Find(int id)
        {
            return this.sampleNomenclatures
                .FirstOrDefault(x => x.Id == id);
        }

        public Nomenclature GetByName(string name)
        {
            return this.sampleNomenclatures
                .FirstOrDefault(x => x.Name == name);
        }
    }
}
