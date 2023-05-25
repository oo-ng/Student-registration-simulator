using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"ID:{Id}{Name}{Major}";
        }
        public string FullDescriptionforStudents=> ToString();

        public int getID()
        {
            return Id;
        }
    }
}
