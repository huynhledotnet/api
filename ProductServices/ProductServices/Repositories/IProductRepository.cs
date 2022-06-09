using ProductServices.DTOs;
using System.Threading.Tasks;

namespace ProductServices.Repositories
{
    public interface IProductRepository
    {
        Task<ProductDetailDTO> GetProductById(int id);
    }
}
