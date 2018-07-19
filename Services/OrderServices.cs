using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Services
{
    public class OrderServices : IOrderServices
    {
        private readonly ApplicationDBContext _db;
        public OrderServices(ApplicationDBContext db)
        {
            
            _db = db;
        }
        public DbSet<Category> GetAllCategories()
        {
           
            var categories = _db.Categories;
            
            return categories;
        }

        
    }
}
