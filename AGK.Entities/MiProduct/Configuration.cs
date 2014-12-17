namespace AGK.Entities.MiProduct
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AGK.Entities.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"MiProduct";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AGK.Entities.ProductDbContext context)
        {
            var pro = new Product()
            {
                Name = "Nhật Khoa",
                Category = new Category() { Name = "Khoa" },
                Manufacturer = new Manufacturer() { Name = "khoasad" },
                Cost = 12000,
                Instock = 1000
            };
            context.Products.Add(pro);
            context.SaveChanges();
        }
    }
}
