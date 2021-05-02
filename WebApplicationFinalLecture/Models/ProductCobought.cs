using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFinalLecture.Models
{
    public class ProductCobought
    {
        [KeyType(77)]
        public uint ProductID { get; set; }

        [KeyType(77)]
        public uint CoboughtProductID { get; set; }

    }
}
