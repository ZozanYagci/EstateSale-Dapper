﻿using EstateSaleProject.Repositories.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateSaleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
                _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values=await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToFalse(id);
            return Ok("İlan Günün Fırsatları Arasından Çıkarıldı");
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToTrue(id);
            return Ok("İlan Günün Fırsatları Arasına Eklendi");
        }

        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }
    }
}
