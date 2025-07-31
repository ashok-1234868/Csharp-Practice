using Microsoft.VisualBasic.Devices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> details = new List<string>()
        {
            "computer science and enginering -CSE",
            "Artificial and inteligence-AIDS",
            "computer tecnology-cse",
            "computer coding-cse"
        };
        private void button_Click(object sender, EventArgs e)
        {
            var mylist = from my in details
                         where my.Contains(course.Text)
                         select my;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(mylist.ToArray());
        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
