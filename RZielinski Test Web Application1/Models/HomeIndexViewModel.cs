using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RZielinski_Test_Web_Application1.Models
{
    public class HomeIndexViewModel
    {
        public int VisitorCount;

        public IList<Category> Categories { get; set; }

        public IList<Product> Products { get; set; }
    }
}
