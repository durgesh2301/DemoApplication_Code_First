using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer.Models
{
    public class Membership
    {
        [StringLength(5)]
        [Key]
        public string MembershipId { get; set; }
        [ForeignKey("User")]
        [Required(ErrorMessage = "EmailId is required.")]
        public string EmailId { get; set; }
        [Phone]
        [Required]
        [StringLength(maximumLength:10, MinimumLength = 10)]
        public string Phone { get; set; }
        public int CreditPoints { get; set; }
        [Required]
        [StringLength(10)]
        [AllowedValues("Gold", "Silver", "Platinum", ErrorMessage = "Invalid membership card type. Allowed values are 'Gold', 'Silver', or 'Platinum'")]
        public string MembershipCardType { get; set; }

        public User User { get; set; }
    }
}
