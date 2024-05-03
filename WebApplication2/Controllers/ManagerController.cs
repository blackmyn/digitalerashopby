using BLL.DTOModels;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public ManagerController(IProductService productService, ICategoryService categoryService, IBrandService brandService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
        }

        public ActionResult Create()
        {
            var categories = _categoryService.GetAll();
            var brands = _brandService.GetAll();

            ViewBag.Categories = categories;
            ViewBag.Brands = brands;

            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductDto product)
        {
            _productService.Add(product);
            return RedirectToAction("Index");
        }

        public ActionResult Products(int page = 1, int pageSize = 10)
        {
            var products = _productService.GetAll();

            var totalCount = products.Count();
            var totalPages = (int)System.Math.Ceiling((double)totalCount / pageSize);

            var paginatedProducts = products.Skip((page - 1) * pageSize).Take(pageSize);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;

            return View(paginatedProducts);
        }

        public ActionResult Brands(int page = 1, int pageSize = 10)
        {
            var products = _brandService.GetAll();

            var totalCount = products.Count();
            var totalPages = (int)System.Math.Ceiling((double)totalCount / pageSize);

            var paginatedProducts = products.Skip((page - 1) * pageSize).Take(pageSize);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;

            return View(paginatedProducts);
        }

        public ActionResult Categories(int page = 1, int pageSize = 10)
        {
            var products = _categoryService.GetAll();

            var totalCount = products.Count();
            var totalPages = (int)System.Math.Ceiling((double)totalCount / pageSize);

            var paginatedProducts = products.Skip((page - 1) * pageSize).Take(pageSize);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;

            return View(paginatedProducts);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(CategoryDto category)
        {
            _categoryService.Add(category);
            return RedirectToAction("Categories");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var category = _categoryService.GetById(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult EditCategory(CategoryDto category)
        {
            _categoryService.Update(category);
            return RedirectToAction("Categories");
        }

        [HttpPost]
        public ActionResult DeleteCategory(int id)
        {
            _categoryService.DeleteById(id);
            return RedirectToAction("Categories");
        }

        [HttpPost]
        public ActionResult CreateBrand(BrandDto category)
        {
            _brandService.Add(category);
            return RedirectToAction("Brands");
        }

        [HttpGet]
        public ActionResult EditBrand(int id)
        {
            var category = _brandService.GetById(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult EditBrand(BrandDto category)
        {
            _brandService.Update(category);
            return RedirectToAction("Brands");
        }

        [HttpPost]
        public ActionResult DeleteBrand(int id)
        {
            _brandService.DeleteById(id);
            return RedirectToAction("Brands");
        }


        public ActionResult Edit(int id)
        {
            var categories = _categoryService.GetAll();
            var brands = _brandService.GetAll();

            ViewBag.Categories = categories;
            ViewBag.Brands = brands;
            var product = _productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(ProductDto product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var product = _productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(ProductDto product)
        {
            _productService.DeleteById(product.Id);
            return RedirectToAction("Index");
        }

    }
}
