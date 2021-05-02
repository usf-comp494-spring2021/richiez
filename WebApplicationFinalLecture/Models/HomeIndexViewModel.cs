using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFinalLecture.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Category> Categories { get; set; }

        public bool GermanyDatasetExists { get; set; }

        public bool UKDatasetExists { get; set; }

        public bool USADatasetExists { get; set; }

        public long Milliseconds { get; set; }
    }
}
