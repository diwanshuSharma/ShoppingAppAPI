namespace ShoppingApp.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingApp.Data.ProductContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ShoppingApp.Data.ProductContextDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for(int i=0; i<10; i++)
            {
                Product product = new Product();
                product.Name =  "" + (i + 1);
                product.Price = 100 + i;
                product.Category = "" + (i % 5);

                context.Products.AddOrUpdate(product);
            }
        }
    }
}
