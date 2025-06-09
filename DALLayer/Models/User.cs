using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer.Models
{
    public class User
    {
        public User()
        {
            PurchaseDetails = new List<PurchaseDetail>();
        }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Key]
        [StringLength(30)]
        public string EmailId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        public string UserPassword { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Role ID must be a positive integer.")]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [Required]
        [StringLength(3)]
        [AllowedValues("M", "F", ErrorMessage = "Invalid")]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters.")]
        public string Address { get; set; }

        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();

        public Role Role { get; set; }
        public Membership Membership { get; set; }

    }
}
