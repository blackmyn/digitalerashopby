using BLL.DTOModels;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using DLL.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProcSpecService _procService;
        private readonly ISpecificationServce _specificationService;
        private readonly ICategoryService _categoryService;
        private readonly IReviewService _reviewService;
        private readonly IBrandService _brandService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(IProductService productService, IProcSpecService procService, ICategoryService categoryService, IReviewService reviewService, IBrandService brandService, ISpecificationServce specificationService, UserManager<ApplicationUser> userManager)
        {
            _productService = productService;
            _procService = procService;
            _specificationService = specificationService;
            _categoryService = categoryService;
            _reviewService = reviewService;
            _brandService = brandService;
            _userManager = userManager;
        }
        public ActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public ActionResult Delete(int id)
        {
             _productService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var productDto = _productService.GetById(id);
            if (productDto == null)
            {
                return NotFound();
            }

            var categoryDto = _categoryService.GetById(productDto.CategoryId);

            var reviews = _reviewService.GetByProductId(id);

            var brandDto = _brandService.GetById(productDto.BrandId);

            var specifications = _procService.GetByProductId(productDto.CategoryId);

            var characteristicNames = new List<string>();
            foreach (var spec in specifications)
            {
                var characteristicName = _specificationService.GetCharacteristicNameById(spec.CharacteristicId);
                characteristicNames.Add(characteristicName);
            }

            ViewData["Specifications"] = specifications;
            ViewData["CharacteristicNames"] = characteristicNames;
            ViewData["Category"] = categoryDto.Name;
            ViewData["Reviews"] = reviews;
            ViewData["Brand"] = brandDto.Name;

            return View(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> WriteReview(int productId, int rating, string comment)
        {
            var user = await _userManager.GetUserAsync(User);
            ViewData["User"] = user.FirstName + user.LastName;
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var reviewDto = new ReviewDto
            {
                ProductId = productId,
                Rating = rating,
                Comment = comment,
                UserId = user.Id
            };
            _reviewService.Add(reviewDto);

            return RedirectToAction("Details", new { id = productId });
        }
        [HttpGet("Search")]
        public IActionResult Search(string term)
        {
            var products = _productService.GetProductsByName(term);
            return Ok(products);
        }
    }
}