using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
