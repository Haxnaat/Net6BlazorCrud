using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Data.Domain
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PermissionName { get; set; } = string.Empty;
    }
}
