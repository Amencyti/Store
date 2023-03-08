using Microsoft.EntityFrameworkCore;
using Shop.Structure;
using Shop.Goods;

namespace Shop.DataBase
{
    public class StoreDBContext : DbContext
    {

        public string DbPath { get; }
        public DbSet<TechItem> TechItems { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<TechModel> TechModels { get; set; }
        public DbSet<TechType> TechTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Till> Tills { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public IGoodsQueries GoodsQueries { get; private set; }
        public IStructureQueries StructureQueries { get; private set; }
        public IRecordsAddQueries RecordsAddQueries { get; private set; }

        public StoreDBContext() : base()
        {
            GoodsQueries = new GoodsQueries();
            GoodsQueries.SetDBContext(this);
            StructureQueries = new StructureQueries();
            StructureQueries.SetDBContext(this);
            RecordsAddQueries = new RecordsAddQueries();
            RecordsAddQueries.SetDBContext(this);
            //var folder = Environment.SpecialFolder.;
            var path = "E:/VisualStudioProjects/shopBlazor/Shop.Goods/UploadGoodsToDB/DB/";
            DbPath = System.IO.Path.Join(path, "Shop.db");
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}