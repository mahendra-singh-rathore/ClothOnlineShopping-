using ClothOnlineShopping.Entities1;
using ClothOnlineShopping.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothOnlineShopping.Services
{
    public class CategoriesService
    {

        public Category GetCategory(int id)
        {
            using (var context = new COSContext())
            {
                return context.Categories.Find(id);
            }
        }

        public List<Category> GetCategory()
        {
            using (var context = new COSContext())
            {
                return context.Categories.ToList();
            }
        }
    
    

        public void SaveCategory(Category category)
        {
            using(COSContext context =new COSContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            using(COSContext context =new COSContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int id)
        {
            using (COSContext context = new COSContext())
            {
                var category = context.Categories.Find(id);
                context.Categories.Remove(category);              
                context.SaveChanges();
            }
        }
    }
}
