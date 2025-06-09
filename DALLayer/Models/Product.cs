using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        [Required]
        [MinLength(0),MaxLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "Numeric(8)")]
        public decimal Price { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity available must be a non-negative integer.")]
        public int QuantityAvailable { get; set; }

        public Category Category { get; set; }
    }
}
