using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;

namespace HelpApp.Application.Services
{
    public class CategoryServices : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryServices(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetCategories()
        {
            var categoriesEntity = await _categoryRepository.GetCategories();
            return _mapper.Map<IEnumerable<ProductDTO>>(categoriesEntity);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var categoriesEntity = await _categoryRepository.GetById(id);
            return _mapper.Map<ProductDTO>(categoriesEntity);
        }

        public async Task Add(ProductDTO categoryDto)
        {
            var categoriesEntity = _mapper.Map<Category>(categoryDto);
            await _categoryRepository.Create(categoriesEntity);
        }

        public async Task Remove(int? id)
        {
            var categoriesEntity = _categoryRepository.GetById(id).Result;
            await _categoryRepository.Remove(categoriesEntity);
        }
        public async Task Update(ProductDTO categoryDto)
        {
            var categoriesEntity = _mapper.Map<Category>(categoryDto);
            await _categoryRepository.Update(categoriesEntity);
        }
    }
}
