using BLL.DTOModels;
using BLL.Interfaces;
using DLL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IDeliveryService _deliveryService;
        private readonly IOrderItemService _orderItemService;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(ICartService cartService, IOrderService orderService, IPaymentService paymentService, IDeliveryService deliveryService, IOrderItemService orderItemService, UserManager<ApplicationUser> userManager)
        {
            _cartService = cartService;
            _orderService = orderService;
            _paymentService = paymentService;
            _deliveryService = deliveryService;
            _orderItemService = orderItemService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Checkout()
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
        public async Task<IActionResult> PlaceOrder(string paymentMethod, string deliveryMethod)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var cartItems = _cartService.GetCartItemsForUser(user.Id);

            var orderId = await _orderService.PlaceOrderAsync(user.Id, cartItems, paymentMethod, deliveryMethod);

            var paymentDto = new PaymentDto
            {
                PaymentMethod = paymentMethod,
                PaymentDate = DateTime.Now,
                Status = "Done",
                OrderId = orderId
            };
            _paymentService.Add(paymentDto);

            var deliveryDto = new DeliveryDto
            {
                DeliveryMethod = deliveryMethod,
                DeliveryDate = DateTime.Now,
                Status = "Done",
                OrderId = orderId
            };
            _deliveryService.Add(deliveryDto);

            //foreach (var item in cartItems)
            //{
            //    var orderItemDto = new OrderItemDto
            //    {
            //        Quantity = item.Quantity,
            //        Price = item.Product.Price,
            //        OrderId = orderId,
            //        ProductId = item.ProductId
            //    };
            //    _orderItemService.Add(orderItemDto);
            //}


            return RedirectToAction("OrderConfirmation");
        }

        public IActionResult OrderConfirmation()
        {
            return View();
        }
    }
}
