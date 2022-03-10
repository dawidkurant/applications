﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Papu.Entities;
using Papu.Models;
using System.Collections.Generic;
using System.Linq;

namespace Papu.Services
{
    public class ProductService : IProductService
    {
        private readonly PapuDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductService(PapuDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        //Pobranie jednego produktu po id 
        public ProductDto GetByIdProduct(int id)
        {
            Product product =
                _dbContext.Products
                .Include(c => c.Category)
                .Include(c => c.Unit)
                .Include(c => c.ProductGroups).ThenInclude(cs => cs.Group)
                .FirstOrDefault(c => c.ProductId == id);


            if (product is null)
            {
                return null;
            }

            var result = _mapper.Map<ProductDto>(product);

            return result;
        }

        //Pobieranie wszystkich produktów z bazy danych
        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _dbContext
                .Products
                .Include(c => c.Category)
                .Include(c => c.Unit)
                .Include(c => c.ProductGroups).ThenInclude(cs => cs.Group)
                .ToList();

            var productsDtos = _mapper.Map<List<ProductDto>>(products);

            return productsDtos;
        }

        //Utworzenie jednego produktu na podstawie obiektu dto 
        public int CreateProduct(CreateProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);

            Category category = _dbContext.Categories
                .FirstOrDefault(c => c.CategoryName == dto.CategoryName);

            Unit unit = _dbContext.Units
               .FirstOrDefault(c => c.UnitName == dto.UnitName);

            product.Category = category;
            product.Unit = unit;

            foreach (var addGroup in dto.GroupId)
            {

                Group group = _dbContext.Groups
                    .FirstOrDefault(s => s.GroupId == addGroup);

                ProductGroup productGroup = new ProductGroup
                {
                    Product = product,
                    Group = group
                };

                _dbContext.ProductGroups.Add(productGroup);
            }

            _dbContext.SaveChanges();

            return product.ProductId;
        }

        //Edycja jednego produktu na podstawie id i obiektu dto
        //tylko ten kto utworzył dany zasób, będzie mógł go modyfikować lub usuwać
        public bool UpdateProduct(int id, UpdateProductDto dto)
        {
            var product =
                _dbContext.Products
                .Include(c => c.Category)
                .Include(c => c.Unit)
                .Include(c => c.ProductGroups).ThenInclude(cs => cs.Group)
                .FirstOrDefault(c => c.ProductId == id);

            //Jeśli jesteśmy pewni, że dany produkt nie istnieje, zwracamy wyjątek
            if (product is null)
            {
                return false;
            }

            Category category = _dbContext.Categories
                .FirstOrDefault(c => c.CategoryName == dto.CategoryName);

            Unit unit = _dbContext.Units
               .FirstOrDefault(c => c.UnitName == dto.UnitName);

            product.ProductName = dto.ProductName;
            product.Category = category;
            product.Unit = unit;
            product.Weight = dto.Weight;
            product.ProductImagePath = dto.ProductImagePath;

            _dbContext.SaveChanges();

            return true;
        }


        //Usunięcie jednego produktu na podstawie id
        //tylko ten kto utworzył dany zasób, będzie mógł go modyfikować lub usuwać
        public bool DeleteProduct(int id)
        {
            var product = 
                _dbContext.Products
                .Include(c => c.Category)
                .Include(c => c.Unit)
                .Include(c => c.ProductGroups).ThenInclude(cs => cs.Group)
                .FirstOrDefault(c => c.ProductId == id);

            if (product is null)
            {
                return false;
            }

            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();

            return true;
        }
    }
}

//[HttpPost("group")]
//public async Task<IActionResult> CreateGroup([FromBody] ProjectGroupModel pro)
//{
//    var dbProject = await _context.Project
//        .Include(p => p.ProjectEmployees)
//        .FirstAsync(p => p.ProjectId == pro.ProjectId);

//    foreach (var old in dbProject.ProjectEmployees)
//    {
//        _context.ProjectEmployee.Remove(old);
//    }

//    dbProject.ProjectEmployees.Clear();

//    foreach (var emp in pro.ProjectEmployees)
//    {
//        dbProject.ProjectEmployees.Add(new ProjectEmployee()
//        {
//            UserId = emp.UserId
//        });
//    }

//    await _context.SaveChangesAsync();

//    return Ok();
//}
