using fiorellopb101.Models;

namespace fiorellopb101.Servioces.Interfaces
{
    public interface ISliderServices
    {
        Task<IEnumerable<Slider>> GetAllasync();
        Task<SliderInfo> GetSliderInfoAsync();
    }
}
