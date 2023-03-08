using Microsoft.EntityFrameworkCore;
using Shop.Goods;

namespace Shop.DataBase
{
    public interface IGoodsQueries
    {
        void SetDBContext(StoreDBContext dbContext);
        TechModel TechModelFromDB(string uid);
        TechType TechTypeFromDB(string uid);
        UnitOfMeasurement UnitOfMeasurementromDB(string name);
        Manufacturer ManufacturerFromDB(string uid);
        List<TechItem> GetAllTechItems();
        TechItem GetTechItemFromDB(string article);

        void SoldItems(List<TechItem> itemsList);
    }

    public class GoodsQueries : IGoodsQueries
    {
        private StoreDBContext _dbContext;

        public virtual TechModel TechModelFromDB(string uid)
        {
            return _dbContext.TechModels.FirstOrDefault(x => x.uid == uid);
        }
        public virtual TechType TechTypeFromDB(string uid)
        {
            return _dbContext.TechTypes.FirstOrDefault(x => x.uid == uid);
        }
        public virtual UnitOfMeasurement UnitOfMeasurementromDB(string name)
        {
            return _dbContext.UnitOfMeasurements.FirstOrDefault(x => x.name == name);
        }
        public virtual Manufacturer ManufacturerFromDB(string uid)
        {
            return _dbContext.Manufacturers.FirstOrDefault(x => x.uid == uid);
        }
        public List<TechItem> GetAllTechItems()
        {
            return _dbContext.TechItems.
            Include(m => m.model).
            Include(t => t.type).
            Include(m => m.manufacturer).ToList<TechItem>();
        }

        public TechItem GetTechItemFromDB(string article)
        {
            return _dbContext.TechItems.
            Include(m => m.model).
            Include(t => t.type).
            Include(m => m.manufacturer).FirstOrDefault(x => x.article == article);
        }

        public void SoldItems(List<TechItem> itemsList)
        {
            foreach (TechItem item in itemsList)
            {
                TechItem itemDB = _dbContext.TechItems.Find(item.id);
                itemDB.count = itemDB.count - 1;
            }
            _dbContext.SaveChanges();
        }

        public void SetDBContext(StoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}