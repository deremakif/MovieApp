using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string IMDb { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
