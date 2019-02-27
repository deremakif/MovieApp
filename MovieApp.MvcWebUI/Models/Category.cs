using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
