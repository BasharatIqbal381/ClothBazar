using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
    public class categoriesService
    {
        CBContext db = new CBContext();
        public Category GetCategory(int Id)
        {
            return db.Catagories.Find(Id);

        }
        public List<Category> GetCategories()
        {
            return db.Catagories.ToList(); 

        }
        public void SaveCategory(Category category)
        {
                db.Catagories.Add(category);
                db.SaveChanges();
            
        }
        public void UpdateCategory(Category category)
        {
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteCategory(int Id)
        {
            var category = db.Catagories.Find(Id);

            db.Catagories.Remove(category);
            db.SaveChanges();

        }
    }
}
