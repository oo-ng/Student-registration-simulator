using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Section
    {
      override public string ToString()
        {
            return $"ID:{Id} CourseID:{CourseId} {Semester} {DayTime} {Course} {Instructor}";
        }
        public int getID() {
            return Id;
        }
    }
}
