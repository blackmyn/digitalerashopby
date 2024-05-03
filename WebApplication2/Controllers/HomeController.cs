using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DLL.Models;
using BLL.Interfaces;
using BLL.Services;
using BLL.DTOModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _userManager = userManager;
            _productService = productService;
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UnauthorizedView()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Category(string category, string sort)
        {
            var selectedCategory = _categoryService.GetByName(category);
            if (selectedCategory == null)
            {
                return NotFound();
            }


            var productsByCategory = _productService.GetProductsByCategory(selectedCategory.Name, sort);

            ViewData["Category"] = selectedCategory.Name;
            ViewData["CategoryId"] = selectedCategory.Id;
            return View(productsByCategory);
        }

        [HttpGet]
        public IActionResult SortProducts(string category, string sort)
        {
            var selectedCategory = _categoryService.GetByName(category);
            if (selectedCategory == null)
            {
                return NotFound();
            }

            var productsByCategory = _productService.GetProductsByCategory(selectedCategory.Name, sort);

            ViewData["Category"] = selectedCategory.Name;
            ViewData["CategoryId"] = selectedCategory.Id;

            return PartialView("_ProductListPartial", productsByCategory);
        }

        [HttpGet]
        public IActionResult SearchProducts(string searchTerm)
        {
            var products = _productService.GetAll();
            var lowerCaseSearchTerm = searchTerm.ToLower();
            var filteredProducts = products.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));

            return PartialView("_ProductSearchPartial", filteredProducts);
        }



        [Authorize]
        public async Task<IActionResult> UserProfile()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}