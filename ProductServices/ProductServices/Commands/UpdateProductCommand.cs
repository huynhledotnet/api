using MediatR;
using ProductServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Commands
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public ProductDetailDTO DTO { get; set; }
    }
}
