using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductAccounterByIDQuery
    {
        public GetProductAccounterByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
