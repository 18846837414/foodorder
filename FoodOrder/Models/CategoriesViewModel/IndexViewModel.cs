using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Models.CategoriesViewModel
{
    public class IndexViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public CategoryViewModel Default
        {
            get { return new CategoryViewModel(); }
        }
    }

    

}
