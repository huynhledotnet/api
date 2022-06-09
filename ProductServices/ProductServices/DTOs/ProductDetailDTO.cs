﻿using System;

namespace ProductServices.DTOs
{
    public class ProductDetailDTO
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        public int ModelYear { get; set; }

        public decimal ListPrice { get; set; }
    }
}