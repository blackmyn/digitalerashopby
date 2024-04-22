using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISpecificationServce _specificationService;
        private readonly ICategoryService _categoryService;
        private readonly IReviewService _reviewService;
        private readonly IBrandService _brandService;

        public ProductController(IProductService productService, ISpecificationServce specificationService, ICategoryService categoryService, IReviewService reviewService, IBrandService brandService)
        {
            _productService = productService;
            _specificationService = specificationService;
            _categoryService = categoryService;
            _reviewService = reviewService;
            _brandService = brandService;
        }

        public IActionResult Details(int id)
        {
            var productDto = _productService.GetById(id);
            if (productDto == null)
            {
                return NotFound();
            }

            // Получение спецификаций для данного товара
            var specifications = _specificationService.GetByProductId(id);

            // Получение категории товара
            var categoryDto = _categoryService.GetById(productDto.CategoryId);

            // Получение отзывов о товаре
            var reviews = _reviewService.GetByProductId(id);

            // Получение бренда товара
            var brandDto = _brandService.GetById(productDto.BrandId);

            // Передача данных в представление через ViewData
            ViewData["Specifications"] = specifications;
            ViewData["Category"] = categoryDto.Name;
            ViewData["Reviews"] = reviews;
            ViewData["Brand"] = brandDto.Name;

            return View(productDto);
        }
    }
}
