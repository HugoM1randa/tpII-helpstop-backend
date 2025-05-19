using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public async Task<IEnumerable<ProductDTO>> GetProduct()
        {
            var productEntity = await _productRepository.GetProduct();
            return _mapper.Map<IEnumerable<ProductDTO>>(productEntity);
        }
        public async Task<ProductDTO> GetById(int? id)
        {
            var productEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Add(ProductDTO productDto)
        {
            var productsEntity = _mapper.Map<Product>(productDto);
            await _productRepository.Create(productsEntity);
        }

        public async Task Remove(int? id)
        {
            
        }

        public async Task Update(ProductDTO productDto)
        {
 
        }
    }
}
