using FazBem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Services
{
    public interface IProductService
    {
        Product Get(long id);
    }

    public class ProductService : IProductService
    {
        public Product Get(long id)
        {
            if (id == 1)
                return CreateProduct1();

            if (id == 2)
                return CreateProduct2();

            if (id == 3)
                return CreateProduct3();

            throw new Exception("Product not found");

        }        

        private Product CreateProduct1()
        {
            var product = new Product
            {
                BarCode = "99283498723984",
                Id = "1",
                Name = "Bolacha Maria"
            };

            product.Comments.Add(new ProductComment { Author = "Wirth", Text = "Produto realmente sem lactose" });
            product.Comments.Add(new ProductComment { Author = "Sato", Text = "Bom produto" });
            product.Comments.Add(new ProductComment { Author = "Maurício", Text = "Coco durinho" });

            return product;
        }

        private Product CreateProduct2()
        {
            var product = new Product
            {
                BarCode = "230948920384",
                Id = "2",
                Name = "Skol"
            };

            product.Comments.Add(new ProductComment { Author = "Maycon", Text = "Desce redondo" });
            product.Comments.Add(new ProductComment { Author = "Wellington", Text = "Feito com milho trangenico" });
            product.Comments.Add(new ProductComment { Author = "Maurício", Text = "Sem coco durinho" });

            return product;
        }

        private Product CreateProduct3()
        {
            var product = new Product
            {
                BarCode = "894375982374",
                Id = "3",
                Name = "Marmite"
            };

            product.Comments.Add(new ProductComment { Author = "Wirth", Text = "Love or hate" });
            product.Comments.Add(new ProductComment { Author = "Sato", Text = "Prefiro sushi" });
            product.Comments.Add(new ProductComment { Author = "Maurício", Text = "Hein?" });

            return product;
        }

    }
}

