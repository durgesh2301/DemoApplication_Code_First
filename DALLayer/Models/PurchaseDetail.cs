using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer.Models
{
    public class PurchaseDetail
    {
        [Key]
        public int PurchaseId { get; set; }
        [Required]
        [ForeignKey("EmailId")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(30)]
        public string EmailId { get; set; }
        [Required]
        [ForeignKey("ProductId")]
        public string ProductId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int QuantityPurchased { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DateOfPurchase { get; set; }
        public virtual User Email { get; set; }

        public virtual Product Product { get; set; }
    }
}
