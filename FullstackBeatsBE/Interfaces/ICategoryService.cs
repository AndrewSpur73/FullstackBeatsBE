using FullstackBeatsBE.DTO;
using FullstackBeatsBE.Models;

namespace FullstackBeatsBE.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> CreateCategoryAsync(CreateCategoryDTO categoryDTO);
        Task<Category> UpdateCategoryAsync(int id, UpdateCategoryDTO categoryDTO);
        Task<Category> DeleteCategoryAsync(int id);
    }
}
