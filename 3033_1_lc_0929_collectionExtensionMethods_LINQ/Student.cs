using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }

        public override string ToString()
        {
            return $"name: {name} age:{age} weight:{weight}";
        }

    }
}
