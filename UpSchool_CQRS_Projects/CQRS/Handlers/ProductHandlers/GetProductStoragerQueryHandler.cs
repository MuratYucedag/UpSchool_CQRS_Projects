using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductStoragerQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductStoragerQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductStoragerQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductStoragerQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Storage = x.Storage
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
