using Microsoft.EntityFrameworkCore;
using Shop.Structure;

namespace Shop.DataBase
{
    public interface IStructureQueries
    {
        void SetDBContext(StoreDBContext dbContext);
        Task<Organization> OrganizationFromDB(string edrpou);
        Task<List<Organization>> AllOrganizationFromDB();
        Task<List<Warehouse>> AllWarehousessFromDB();
        Task<List<Store>> AllStoresFromDB();
        
    }

    public class StructureQueries : IStructureQueries
    {
        private StoreDBContext _dbContext;

        public virtual Task<Organization> OrganizationFromDB(string edrpou)
        {
            return _dbContext.Organizations.FirstOrDefaultAsync(x => x.edrpou == edrpou);
        }

        public virtual Task<List<Organization>> AllOrganizationFromDB()
        {
            return _dbContext.Organizations.ToListAsync<Organization>();
        }

        public virtual Task<List<Store>> AllStoresFromDB()
        {
            return _dbContext.Stores.ToListAsync<Store>();
        }

         public virtual Task<List<Warehouse>> AllWarehousessFromDB()
        {
            return _dbContext.Warehouses.ToListAsync<Warehouse>();
        }

        public void SetDBContext(StoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}