using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFinalLecture.Models
{
    public class HomeCartViewModel
    {
        public Cart Cart { get; set; }

        public List<EnrichedRecommendation> Recommendations { get; set; }
    }
}
