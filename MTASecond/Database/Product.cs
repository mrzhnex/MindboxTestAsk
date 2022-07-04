using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MTASecond.Database
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Category> Categories { get; set; } = new();
    }
}