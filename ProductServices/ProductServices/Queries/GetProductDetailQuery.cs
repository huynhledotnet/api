using MediatR;
using ProductServices.DTOs;

namespace ProductServices.Queries
{
    public class GetProductDetailQuery : IRequest<ProductDetailDTO>
    {
        public int Id { get; set; }
    }
}
