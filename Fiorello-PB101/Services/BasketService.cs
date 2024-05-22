//using Fiorello_PB101.Data;
//using Fiorello_PB101.Models;
//using Fiorello_PB101.Services.Interfaces;
//using Fiorello_PB101.ViewModels.Baskets;
//using Microsoft.EntityFrameworkCore;

//namespace Fiorello_PB101.Services
//{
//    public class BasketService : IBasketService
//    {
//        private readonly AppDbContext _context;

//        public BasketService(AppDbContext context)
//        {
//            _context = context;
//        }


//        public async Task<IEnumerable<Product>> GetAllAsync()
//        {
//            return await _context.Products.Include(m => m.ProductImages).ToListAsync();

//        }
//    }
//}
