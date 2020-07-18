﻿namespace EfCoreInheritance.Models
{
    public class ProductSaleDetail : SaleDetail
    {
        protected ProductSaleDetail() {}

        public ProductSaleDetail(Sale sale, Product product, Unit unit) : base(sale)
        {
            Product = product;
            Unit = unit;
        }
        public Product Product { get; set; }
        public long ProductId { get; set; }
        public Unit Unit { get; set; }
        public long UnitId { get; set; }
        
    }
}