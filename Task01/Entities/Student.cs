using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Entities
{
    internal class Student
    {
        // 1. By using the convention Default way
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public int Dep_Id { get; set; }
    }
}
