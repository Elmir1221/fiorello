using fiorellopb101.Models;
using fiorellopb101.ViewModels.Blog;

namespace fiorellopb101.Servioces.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync( int? take=null);
        //Task<SliderInfo> GetSliderInfoAsync();

    }
}
