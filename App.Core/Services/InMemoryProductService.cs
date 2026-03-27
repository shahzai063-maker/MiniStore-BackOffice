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
            if (product != null)
            {
                product.Id = GenerateId();
                _products.Add(product);
            }
            return product;
        }

        public bool Delete(string id)
        {
            Product prodToBeDeleted = GetById(id);
            _products.Remove(prodToBeDeleted);
            return true;
        }

         public List<Product> GetAll()
        {
            return _products.OrderBy(P => P.Name).ToList();
        }

        public Product GetById(string id)
        {
            Product? prod = _products.Find(p => p.Id == id);
            return prod;
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            List<Product> _filtered = _products.ToList();
            _filtered = _filtered.Where(p => p.Name.Contains(text)).ToList();

            if (category is not null) 
            {
                _filtered = _filtered.Where(p => p.Category == category).ToList();
            }
            return _filtered;
        }

        public bool Update(Product product)
        {
            if (product != null)
            {
                Product? existing = _products.Find(p => p.Id == product.Id);
                if (existing == null) return false;

                existing.Name = product.Name;
                existing.Category = product.Category;
                existing.price = product.price;
                existing.Status = product.Status;
                existing.Stock = product.Stock;

                return true;


            }
            return false;
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

        public void Search(string searchText, ProductCategoryEnum? category, object status)
        {
            throw new NotImplementedException();
        }
    }
}
