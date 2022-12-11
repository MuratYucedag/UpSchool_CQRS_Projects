using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ProduceofDate = command.ProduceofDate,
                EndofDate = command.EndofDate,
                Status = true
            });
            _productContext.SaveChanges();
        }
    }
}
