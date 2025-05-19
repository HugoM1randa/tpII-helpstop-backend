using HelpApp.Application.DTOs;

namespace HelpApp.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<ProductDTO>> GetCategories();
        Task<ProductDTO> GetById(int? id);
        Task Add(ProductDTO categoryDto);
        Task Update(ProductDTO categoryDto);
        Task Remove(int? id);
    }
}
