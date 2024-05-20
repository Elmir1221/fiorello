using fiorellopb101.Servioces.Interfaces;
using fiorellopb101.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace fiorellopb101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderServices _sliderServices;
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public HomeController(ISliderServices sliderServices, 
                                    IBlogService blogService,
                                    ICategoryService categoryService,
                                    IProductService productService)

        {
            _sliderServices = sliderServices;
            _blogService = blogService;
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task< IActionResult> Index()
        {
            HomeVM model = new()
            {
                Sliders = await _sliderServices.GetAllasync(),
                SliderInfo = await _sliderServices.GetSliderInfoAsync(),
                Blogs = await _blogService.GetAllAsync(3),
                Categories =await _categoryService.GetAllAsync(),
                Products = await _productService.GetAllAsync(),


            };
            return View(model);
        }
      
    }
}