using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext productContext)
        {
            _context = productContext;
        }

        public void Handle(CreateStudentCommand command) 
        {
            _context.Students.Add(new Student
            {
                Age = command.Age,
                Name = command.Name,
                City = command.City,
                Surname = command.Surname,
                Status = false
            });
            _context.SaveChanges();
        }
    }
}
