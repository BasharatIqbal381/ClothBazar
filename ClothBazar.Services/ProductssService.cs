using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
    public class ProductsService
    {
        CBContext db = new CBContext();
        public Product GetProduct(int Id)
        {
            return db.Products.Find(Id);

        }
        public List<Product> GetProducts()
        {
            return db.Products.ToList(); 

        }
        public void SaveProduct(Product product)
        {
                db.Products.Add(product);
                db.SaveChanges();
            
        }
        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteProduct(int Id)
        {
            var product = db.Products.Find(Id);

            db.Products.Remove(product);
            db.SaveChanges();

        }
    }
}
