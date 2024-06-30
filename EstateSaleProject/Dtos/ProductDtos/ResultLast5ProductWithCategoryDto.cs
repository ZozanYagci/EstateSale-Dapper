namespace EstateSaleProject.Dtos.ProductDtos
{
    public class ResultLast5ProductWithCategoryDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public string CategoryName { get; set; }
        public DateTime AdvertisementDate { get; set; }
    }
}
