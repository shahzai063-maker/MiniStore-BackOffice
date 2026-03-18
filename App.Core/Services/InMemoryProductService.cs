using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;
        public InMemoryProductService() {

            _products = new List<Product>();
            GeneratefakeProdcts();
        }
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

         public List<Product> GetAll()
        {
            return _products.OrderBy(P => P.Name).ToList();
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product Product)
        {
            throw new NotImplementedException();
        }
        public void GeneratefakeProdcts()
        {
            _products.Clear();
            _products.Add(new Product{
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronices,
                price = 150000.00m,
                Stock = 10,
                 Status = ProductStatusEnum.Active

            });
            _products.Add(new Product{
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronices,
                Status = ProductStatusEnum.Active,
                price = 1200m,
                Stock = 18,
            });
           }
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}
