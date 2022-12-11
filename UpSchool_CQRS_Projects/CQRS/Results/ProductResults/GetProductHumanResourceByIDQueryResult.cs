using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Results.ProductResults
{
    public class GetProductHumanResourceByIDQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
    }
}
