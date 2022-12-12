﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.DAL.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Faculty { get; set; }
        public string Mail { get; set; }
        public bool Status { get; set; }
        public int Age { get; set; }
    }
}
