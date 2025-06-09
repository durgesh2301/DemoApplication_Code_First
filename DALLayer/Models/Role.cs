using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DALLayer.Models;

public partial class Role
{
    public Role()
    {
        Users = new List<User>();
    }
    public int RoleId { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Role name cannot be longer than 50 characters.")]
    public string RoleName { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
