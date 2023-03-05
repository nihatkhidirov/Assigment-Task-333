using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_Task_3
{
    internal class Student
    {

        public string name;
        public string surname;
        public string age;
        public string speciality;
        public string groupNo;
        public override string ToString()
        {
            return $"{name}-{surname}-{age}-{speciality}-{groupNo}";
        }
    }
}
