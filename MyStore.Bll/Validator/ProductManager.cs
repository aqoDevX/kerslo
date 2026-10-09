using MyStore.Bll.Services;
using MyStore.Core.Entities;
using MyStore.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Bll.Validator
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void AddProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Məhsulun adı boş ola bilməz!");
            }

            if (product.Price <= 0)
            {
                throw new ArgumentException("Məhsulun qiyməti 0 və ya daha az ola bilməz!");
            }

            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Məhsulun adı boş ola bilməz!");
            }

            if (product.Price <= 0)
            {
                throw new ArgumentException("Məhsulun qiyməti 0 və ya daha az ola bilməz!");
            }

            _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _productRepository.GetById(id);
            if (product != null)
            {
                _productRepository.Delete(product);
            }
        }
    }
}
