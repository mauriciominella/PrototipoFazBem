using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Models
{
    public class UserRating
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        public bool Like { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
