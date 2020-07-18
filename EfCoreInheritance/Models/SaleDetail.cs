﻿namespace EfCoreInheritance.Models
{
    public class SaleDetail : GenericModel 
    {
        protected SaleDetail(){}
        public SaleDetail(Sale sale) { Sale = sale; }
        public Sale Sale { get; set; }
        public long SaleId { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount => Quantity * Rate;
    }
}