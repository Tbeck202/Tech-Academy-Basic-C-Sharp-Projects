using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstConstructorChainDrill
{
    public class Student
    {
        public Student(int id) : this("Name unknown", id)
        {
        }
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
