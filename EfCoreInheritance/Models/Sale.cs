using System.Collections.Generic;
using System.Linq;

namespace EfCoreInheritance.Models
{
    public class Sale : GenericModel
    {
        
        public Stakeholder Stakeholder { get; set; }
        public long StakeholderId { get; set; }
        public List<SaleDetail> SaleDetailList { get; set; } = new List<SaleDetail>();
        public double Amount => SaleDetailList.Sum(x => x.Amount);
    }
}