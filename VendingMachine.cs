using System;
using System.Collections.Generic;
using System.Linq;

namespace Vending
{
    public class VendingMachine
    {
        private List<Product> _products = new List<Product>();

        public VendingMachine()
        {
            _products.Add(new Product() { Id = 1, Name = "Snickers", Price = .75 });
            _products.Add(new Product() { Id = 2, Name = "Pepsi", Price = 1.25 });
            _products.Add(new Product() { Id = 3, Name = "Diamond Ring", Price = 2_400 });
            _products.Add(new Product() { Id = 4, Name = "Tesla", Price = 85_000 });
            _products.Add(new Product() { Id = 5, Name = "Hot Pocket", Price = 1.50 });
        }

        // Add a new product to the Vending Machine (For stocking machine)
        public void AddProduct(Product newProduct)
        {
            _products.Add(newProduct);
            // throw new NotImplementedException();
        }

        // Remove a product from the Vending Machine (for purchasing a product)
        public void RemoveProduct(Product productToRemove)
        {
            //     throw new NotImplementedException();
            _products.Remove(productToRemove);
        }

        // Get all products ordered by price (lowest on top)
        public List<Product> GetAll()
        {
            var productsInOrder = _products.OrderBy(p => p.Price);
            return productsInOrder.ToList();
           
        }

        // Find a product by name. Results should be ordered by name)
        public List<Product> SearchByName(string nameCriteria)
        {
            IEnumerable<Product> searchByNameProduct = _products.Where(p => p.Name.Contains(nameCriteria));
            //    var searchResultsOrderedByName = searchByNameProduct.OrderBy(p => p.Name);
            return searchByNameProduct.OrderBy(n => n.Name).ToList();

        }

        // Find a product between a range or prices. Results should be ordered by price
        public List<Product> SearchByPrice(double minPrice, double maxPrice)
        {
            var priceRange = _products.Where(p => p.Price >= minPrice && p.Price <= maxPrice);

            return priceRange.OrderBy(p => p.Price).ToList();

           
        }

        // Return a product with a given ID. Return null if not found.
        public Product GetById(int id)
        {
            var prodId = _products.Find(p => p.Id == id);
            if (prodId != null)
            {
                return prodId;
            }
            else
            {
                return null;
            }
    
        }

        // Return the cheapest product or null if there are no products
        public Product GetCheapest()
        {
            throw new NotImplementedException();
        }

        // Return the most expensive product or null if there are no products
        public Product GetMostExpensive()
        {
            throw new NotImplementedException();
        }

        // Return all the product names in alphabetical ordere
        public List<string> GetProductNames()
        {
            throw new NotImplementedException();
        }

        // Property to represent the total of all the products' prices.
        public double TotalValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}