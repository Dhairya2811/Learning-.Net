using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public override float ComputeGradeAverage()
        {
            // TODO: fix the implementation later
            return 0.00f;
        }

    }
}
