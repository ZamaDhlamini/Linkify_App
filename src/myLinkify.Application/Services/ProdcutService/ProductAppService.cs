using Abp.Application.Services;
using myLinkify.Domain;
using myLinkify.Services.ProdcutService.Dto;
using myLinkify.Services.ProdcutService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace myLinkify.Services.ProductService
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductAppService(IRepository productRepository)
        {
            _productRepository = (IRepository<Product, Guid>)productRepository;
        }

        public async Task<ProductDto> CreateAsync(ProductDto input)
        {
            var product = ObjectMapper.Map<Product>(input);
            product.Id = Guid.NewGuid();
            await _productRepository.InsertAsync(product);
            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task Delete(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllListAsync();
            return ObjectMapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetAsync(Guid id)
        {
            var product = await _productRepository.GetAsync(id);
            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> UpdateAsync(ProductDto input)
        {
            var product = await _productRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, product);
            await _productRepository.UpdateAsync(product);
            return ObjectMapper.Map<ProductDto>(product);
        }
    }
}
