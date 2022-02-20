using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Data.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }=string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        [Required]
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }

    }

    public class UserDto
    {
        
       
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [Required]
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }

    }
}
