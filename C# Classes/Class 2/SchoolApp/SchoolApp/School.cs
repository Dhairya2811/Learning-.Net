using System.Text;

namespace SchoolApp
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string phoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress {
            // make sure this Twitter address starts with @
            get { return _twitterAddress; }
            set {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The Twitter address must starts with @");
                }
            }
        }
        public School() {
            Name = "Untitled School";
            phoneNumber = "555-1234";
        }
        public School(string SchoolName, string SchoolphoneNumber) {
            Name = SchoolName;
            phoneNumber = SchoolphoneNumber;
        }
        //public float AverageThreeScores(float a, float b, float c) {
        //    var result = (a + b + c) / 3;
        //    return result;
        //}
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", "+State);
            sb.AppendLine(" ");
            sb.AppendLine(Zip);

            return sb.ToString();
        }
    }
}
