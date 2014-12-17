using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGK.Entities
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("name=StoreConnection")
        {

        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
