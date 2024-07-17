﻿namespace EstateSaleProject.Dtos.ProductDtos
{
    public class GetProductByProductIdDto
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public bool DealOfTheDay { get; set; }
        public DateTime AdvertisementDate { get; set; }
        public string SlugUrl { get; set; }
    }
}