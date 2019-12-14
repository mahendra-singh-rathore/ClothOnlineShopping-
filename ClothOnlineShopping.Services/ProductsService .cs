using ClothOnlineShopping.Entities1;
using ClothOnlineShopping.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothOnlineShopping.Services
{
    public class ProductsService
    {

        public Product GetProduct(int id)
        {
            using (var context = new COSContext())
            {
                return context.Products.Find(id);
            }
        }

        public List<Product> GetProduct()
        {
            using (var context = new COSContext())
            {
                return context.Products.ToList();
            }
        }
    
    
        public void SaveProduct(Product product)
        {
            using(COSContext context =new COSContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using(COSContext context =new COSContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int id)
        {
            using (COSContext context = new COSContext())
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);              
                context.SaveChanges();
            }
        }
    }
}
