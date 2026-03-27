using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
    public interface IProductService
    {
        public Product Add(Product product);
        public bool Update(Product Product);
        public bool Delete(String id);
        public Product GetById(String id);
        public List<Product> GetAll();
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status);
        void Search(string searchText, ProductCategoryEnum? category, object status);
    }
}
