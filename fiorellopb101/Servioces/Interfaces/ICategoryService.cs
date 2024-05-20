using fiorellopb101.Models;

namespace fiorellopb101.Servioces.Interfaces
{
    public interface ICategoryService 
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
