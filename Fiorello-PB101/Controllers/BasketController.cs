//using Fiorello_PB101.Services;
//using Fiorello_PB101.Services.Interfaces;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Fiorello_PB101.Controllers
//{
//    public class BasketController : Controller
//    {
//        private readonly IBasketService _basketService;

//        public BasketController(IBasketService basketService)
//        {
//            _basketService = basketService;
//        }

//        public async Task<IActionResult> Index()
//        {
//            return View(await _basketService.GetAllAsync());
//        }

//    }
//}
