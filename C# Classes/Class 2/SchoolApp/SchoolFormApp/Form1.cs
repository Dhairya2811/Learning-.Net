using SchoolApp;

namespace SchoolFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPushToText_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = name.Text;
            testSchool.Address = address.Text;
            testSchool.City = city.Text;
            testSchool.State = state.Text;
            testSchool.Zip = zip.Text;
            testSchool.phoneNumber = phoneNumber.Text;
            try {
                testSchool.TwitterAddress = twitter.Text;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());
        }
    }
}