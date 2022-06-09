using MediatR;
using ProductServices.DTOs;
using ProductServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductServices.Queries
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDetailDTO>
    {
        private readonly IProductRepository _productRepository;
        public GetProductDetailQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDetailDTO> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {

            return await _productRepository.GetProductById(request.Id);
        }
    }
}
