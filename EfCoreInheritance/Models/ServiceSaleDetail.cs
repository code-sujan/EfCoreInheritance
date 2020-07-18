﻿namespace EfCoreInheritance.Models
{
    public class ServiceSaleDetail : SaleDetail
    {
        protected ServiceSaleDetail(){}

        public ServiceSaleDetail(Sale sale, Service service) : base(sale) { Service = service; }
        public Service Service { get; set; }
        public long ServiceId { get; set; }
        
    }
}