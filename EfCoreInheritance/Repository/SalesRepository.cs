using System.Threading.Tasks;
using EfCoreInheritance.DbContext;
using EfCoreInheritance.Models;
using EfCoreInheritance.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreInheritance.Repository
{
    public class SalesRepository : ISalesRepository
    {
        private readonly Context _context;
        public SalesRepository(Context context) { _context = context;}
        
        public async Task<Sale> FindById(long id)
        {
            return await _context.Sales.Include(x => x.Stakeholder)
                .Include(x => x.SaleDetailList)
                .ThenInclude(x => (x as ProductSaleDetail).Product)
                .Include(x => x.SaleDetailList)
                .ThenInclude(x => (x as ProductSaleDetail).Unit)
                .Include(x => x.SaleDetailList)
                .ThenInclude(x => (x as ServiceSaleDetail).Service)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        
    }
}