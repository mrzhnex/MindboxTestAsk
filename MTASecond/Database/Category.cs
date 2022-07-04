using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MTASecond.Database
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}