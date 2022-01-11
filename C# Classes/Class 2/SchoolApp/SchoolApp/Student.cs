using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Student : Person
    {
        public enum GradeLevel { Freshman, Sophomore, Junior, Senior }
        public GradeLevel gradeLevel { get; set; }
        public override float ComputeGradeAverage() {
            // TODO: fix the implementation later
            return 4.00f;
        }
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
