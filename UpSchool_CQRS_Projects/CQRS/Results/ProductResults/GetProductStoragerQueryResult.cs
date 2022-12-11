using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Results.ProductResults
{
    public class GetProductStoragerQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
    }
}
