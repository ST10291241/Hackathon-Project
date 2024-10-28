using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class Users
    {
        [Key]
        public string? BadgeNumber { get; set; }

        [Key]
        public string? BranchNumber { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
