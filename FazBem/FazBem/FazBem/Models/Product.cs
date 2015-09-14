using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public IList<ProductComment> Comments { get; set; }
    }

    public class ProductComment
    {
        public ProductComment()
        {
            this.DateTime = DateTime.Now;
        }

        public string Author { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
    }
}
