using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public class CategoryRepository
    {
        private static List<Category> categories = null;
        static CategoryRepository()
        {
            categories = new List<Category>()
            {
               new Category(){ Id=1,Name="Melankoli"},
               new Category(){ Id=2,Name="Zamanda Yolculuk"},
               new Category(){ Id=3,Name="Seri Katil"},
               new Category(){ Id=4,Name="Romantik"}
            };

        }

        public static List<Category> Categories
        {
            get { return categories; }
        }

        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }    
    }
}
