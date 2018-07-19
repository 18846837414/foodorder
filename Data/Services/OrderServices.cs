using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly ApplicationDBContext _db;

        public OrderServices(ApplicationDBContext db)
        {

            _db = db;
        }

        public async Task<bool> CategoryExists(int id)
        {
            return await _db.Categories.AnyAsync(e => e.Id == id);
        }

        public async Task<Category> CreateCategoryAsync(Category category)
        {
            await _db.Categories.AddAsync(category);
            var saved = await _db.SaveChangesAsync();
            if (saved == 0)
                return null;
            
            return category;
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _db.Categories.SingleOrDefaultAsync(m => m.Id == id);
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
        }
       
        public async Task<Category> EditCategoryAsync(Category category)
        {
            var cat = await _db.Categories
                 .SingleOrDefaultAsync(m => m.Id == category.Id);
            if (category == null)
                return null;
            cat.Name = category.Name;
            cat.DisplayOrder = category.DisplayOrder;
            var saved = await _db.SaveChangesAsync();
            if (saved == 0)
                return null;

            return category;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {

            var categories = await _db.Categories.ToListAsync();

            return categories;
        }

        public async Task<Category> GetCategoryAsync(int? id)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id.Equals(id));
            return category;
        }
    }
}
