using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands
{
    public class RemoveStudentCommand
    {
        public RemoveStudentCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
