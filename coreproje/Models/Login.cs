using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreproje.Models
{
    public class Login
    {
        [Key]
        public int AdminId { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
    }
}
