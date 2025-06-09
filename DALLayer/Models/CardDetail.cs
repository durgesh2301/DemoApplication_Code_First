using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DALLayer.Models;

public partial class CardDetail
{
    [Key]
    [Range(1000000000000000, 9999999999999999, ErrorMessage = "Card number must be a 16-digit number.")]    
    public decimal CardNumber { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Name on card cannot be longer than 50 characters.")]
    public string NameOnCard { get; set; }
    [Required]
    [AllowedValues("A","M","V", ErrorMessage = "Invalid card type. Allowed values are 'A', 'M' or 'V'")]
    [StringLength(3)]
    public string CardType { get; set; }
    [Required]
    [Range(100, 999, ErrorMessage = "CVV number must be a 3-digit number.")]
    public decimal Cvvnumber { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateOnly ExpiryDate { get; set; }
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Balance must be a non-negative number.")]
    public decimal Balance { get; set; }
}
