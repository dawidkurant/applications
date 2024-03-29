﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Papu.Models;
using Papu.Services;

namespace Papu.Controllers
{
    [Route("api/product")]
    [ApiController]
    // Atrybut potrzebny aby dane akcje były zablokowane przed niezalogowanymi użytkownikami
    // [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // Pobranie konkretnego produktu
        [HttpGet("{id}")]
        // Ta akcja nie wymaga autoryzacji
        [AllowAnonymous]
        public ActionResult<ProductDto> GetProduct([FromRoute] int id)
        {
            var product = _productService.GetByIdProduct(id);

            return Ok(product);
        }

        // Pobranie wszystkich produktów z bazy i zwrócenie ich do klienta z kodem 200 czyli OK
        [HttpGet]
        [AllowAnonymous]
        public ActionResult<ProductDto> GetAllProducts()
        {
            var productsDtos = _productService.GetAllProducts();

            return Ok(productsDtos);
        }

        // Tworzenie nowego produktu
        [HttpPost]
        [AllowAnonymous]
        public ActionResult CreateProduct([FromBody] CreateProductDto dto)
        {
            var newProductId = _productService.CreateProduct(dto);

            // Jako pierwszy parametr ścieżka, a jako drugi
            // możemy zwrócić ciało odpowiedzi, ale w tym wypadku zwracamy null
            return Created($"api/product/{newProductId}", null);
        }

        // Edycja produktu
        [HttpPut("{id}")]
        [AllowAnonymous]
        public ActionResult UpdateProduct([FromBody] UpdateProductDto dto, [FromRoute] int id)
        {
            _productService.UpdateProduct(id, dto);

            return Ok();
        }

        // Usuwanie produktu
        [HttpDelete("{id}")]
        [AllowAnonymous] // do usunięcia
        public ActionResult DeleteProduct([FromRoute] int id)
        {
            _productService.DeleteProduct(id);

            // operacja zakończona sukcesem
            return NoContent();
        }
    }
}
