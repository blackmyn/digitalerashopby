using Microsoft.AspNetCore.Mvc;
using BLL.DTOModels;
using BLL.Interfaces;
using DLL.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(ICartService cartService, UserManager<ApplicationUser> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }
        [HttpPost]
        public IActionResult RemoveFromCart(int cartItemId)
        {
            _cartService.DeleteById(cartItemId);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var cartItems = _cartService.GetCartItemsForUser(user.Id);
                return View(cartItems);
            }
            else
            {
                return View(new List<CartDto>());
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity)
        {
            var user = await _userManager.GetUserAsync(User);
            var cartItem = new CartDto
            {
                ProductId = productId,
                Quantity = quantity,
                UserId = user.Id
            };

            _cartService.Add(cartItem);
            TempData["CartSuccessMessage"] = "Товар успешно добавлен в корзину.";
            return RedirectToAction("Details", "Product", new { id = productId });
        }
    }
}
