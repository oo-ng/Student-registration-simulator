using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestProject
{
    public partial class Registration
    {
        public override string ToString()
        {
            return $"ID: {Id}, SectionID:{SectionId}, StudentID:{StudentId}, Grade:{Grade}";
        }

        public void  delete()
        {
           Registration registration = new Registration();
            
        }
    }
}
