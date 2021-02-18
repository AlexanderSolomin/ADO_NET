using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO_NET.U7E1.LinqStudent
{
    class Student
    {
        public string First { get; set; } 
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }
}
