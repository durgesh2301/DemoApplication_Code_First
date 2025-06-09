using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Category name cannot be longer than 20 characters.")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } 
    }
}
