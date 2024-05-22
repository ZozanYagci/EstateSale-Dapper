﻿
namespace EstateSaleUI.Dtos.ProductDtos
{
    public class ResultProductDtos
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public object CategoryName { get; set; }
    }
}
