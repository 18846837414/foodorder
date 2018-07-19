using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOrderServices
    {
        DbSet<Category> GetAllCategories();
    }
}
