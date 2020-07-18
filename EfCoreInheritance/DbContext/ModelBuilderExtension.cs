using EfCoreInheritance.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreInheritance.DbContext
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Stakeholder>().HasData(
                new Stakeholder{Id = 1, Name = "Stakeholder", Address = "address"}
            );
            
            builder.Entity<Product>().HasData(
                new Product {Id = 1, Name = "product", TotalQuantity = 10, PurchaseRate = 10}
            );

            builder.Entity<Unit>().HasData(
                new Unit {Id = 1, Name = "unit"}
            );

            builder.Entity<Models.Service>().HasData(
                new Models.Service {Id = 1, Name = "service", Rate = 10}
            );

            // builder.Entity<Sale>().HasData(
            //     new Sale {Id = 1, StakeholderId = 1}
            // );
            //
            // builder.Entity<ProductSaleDetail>().HasData(
            //     new ProductSaleDetail {Id = 1, SaleId = 1, ProductId = 1, UnitId = 1, Quantity = 10, Rate = 10}
            // );
            //
            // builder.Entity<ServiceSaleDetail>().HasData(
            //     new ServiceSaleDetail {Id = 2, SaleId = 1, ServiceId = 1, Rate = 10, Quantity = 1}
            // );
        }
    }
}