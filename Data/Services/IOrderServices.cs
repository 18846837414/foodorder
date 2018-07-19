using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Services
{
    public interface IOrderServices
    {
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns List="Category"></returns>
        Task<List<Category>> GetAllCategoriesAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns Category></returns>
        Task<Category> GetCategoryAsync(int? id);

        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteCategoryAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns Category></returns>
        Task<Category> EditCategoryAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns Category></returns>
        Task<Category> CreateCategoryAsync(Category category);

        /// <summary>
        /// Checks if a category exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> CategoryExists(int id);
    }
}
