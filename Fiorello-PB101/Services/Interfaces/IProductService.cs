using Fiorello_PB101.Models;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();


        Task<Product> GetByIdWithAllDatasAsync(int id);

        Task<Product> GetByIdAsAsync(int id);
    }
}
