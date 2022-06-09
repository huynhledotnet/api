using Dapper;
using ProductServices.Context;
using ProductServices.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;
        public ProductRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<ProductDetailDTO> GetProductById(int id)
        {
            var query = $@"SELECT product_id AS ProductId,
       product_name AS ProductName,
       brand_id AS BrandId,
       category_id AS CategoryId,
       model_year AS ModelYear,
       list_price AS ListPrice
FROM huynhlex_db.production.products
WHERE product_id = @productId";
            using (var connection = _context.CreateConnection())
            {
                var parameters = new 
                {
                    productId = id
                };

                var product = await connection.QueryAsync<ProductDetailDTO>(query, param: parameters);
                var result = product.SingleOrDefault();
                result.BrandId = 99999999;
                return result;
            }
        }
    }
}
