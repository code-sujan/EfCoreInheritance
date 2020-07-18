using System.Threading.Tasks;
using EfCoreInheritance.Models;

namespace EfCoreInheritance.Repository.Interfaces
{
    public interface ISalesRepository
    {
        Task<Sale> FindById(long id);
    }
}