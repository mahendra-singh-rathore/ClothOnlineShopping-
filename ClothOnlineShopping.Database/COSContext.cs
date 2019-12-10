using ClothOnlineShopping.Entities1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothOnlineShopping.Database
{
    class COSContext:DbContext
    {
        public COSContext():base("ClothOnlineShopping")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
