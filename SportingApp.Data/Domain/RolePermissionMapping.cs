using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Data.Domain
{
    public class RolePermissionMapping
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }
        public int PermissionId { get; set; }
        public virtual Permission? Permission { get; set; }
    }
}
