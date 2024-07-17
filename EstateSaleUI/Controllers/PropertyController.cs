using EstateSaleUI.Dtos.ProductDetailDtos;
using EstateSaleUI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EstateSaleUI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
           
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44362/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> PropertyListWithSearch(string searchKeyValue, int propertyCategoryId, string city)
        {
            ViewBag.searchKeyValue = TempData["searchKeyValue"];
            ViewBag.propertyCategoryId = TempData["propertyCategoryId"];
            ViewBag.city = TempData["city"];

            searchKeyValue = TempData["searchKeyValue"].ToString();
            propertyCategoryId = int.Parse(TempData["propertyCategoryId"].ToString());
            city = TempData["city"].ToString();

            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44362/api/Products/ResultProductWithSearchList?searchKeyValue={searchKeyValue}&propertyCategoryId={propertyCategoryId}&city={city}");

            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        //[HttpGet("property/{slug}/{id}")]
        [HttpGet]
        public async Task<IActionResult> PropertySingle(string slug, int id)
        {
            //ViewBag.i = id;
            id = 1;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44362/api/Products/GetProductByProductId?id=" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDto>(jsonData);

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44362/api/ProductDetails/GetProductDetailByProductId?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailByIdDto>(jsonData2);

            ViewBag.productId = values.ID;
            ViewBag.title1 = values.Title.ToString();
            ViewBag.price = values.Price;
            ViewBag.city = values.City;
            ViewBag.district = values.District;
            ViewBag.address = values.Address;
            ViewBag.type = values.Type;
            ViewBag.description = values.Description;
            //ViewBag.slugUrl = values.SlugUrl;

            ViewBag.bathCount = values2.BathCount;
            ViewBag.bedCount = values2.BedroomCount;
            ViewBag.size = values2.ProductSize;
            ViewBag.roomCount = values2.RoomCount;
            ViewBag.garageCount = values2.GarageSize;
            ViewBag.buildYear = values2.BuildYear;
            ViewBag.date = values.AdvertisementDate;
            ViewBag.location = values2.Location;
            ViewBag.videoUrl = values2.VideoUrl;

            DateTime date1 = DateTime.Now;
            DateTime date2 = values.AdvertisementDate;

            TimeSpan timeSpan = date1 - date2;
            int month = timeSpan.Days;

            ViewBag.datediff = month / 30;

            //string slugFromTitle = CreateSlug(values.title);
            //ViewBag.slugUrl = slugFromTitle;

            return View();
        }

    }
}
