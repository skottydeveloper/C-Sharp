using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace MathsWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public static void OpenUrl(string url)
        {
            try
            {
                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                Process.Start(chromePath, url);
            }
            catch
            {
                // Handle exceptions, if any
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:7154/api/Addition?";
            string x = textBox1.Text;
            string y = textBox2.Text;
            url += "x=" + x + "&y=" + y;

            OpenUrl(url);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:7154/api/Division?";
            string x = textBox1.Text;
            string y = textBox2.Text;
            url += "x=" + x + "&y=" + y;

            OpenUrl(url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:7154/api/Multiplication?";
            string x = textBox1.Text;
            string y = textBox2.Text;
            url += "x=" + x + "&y=" + y;

            OpenUrl(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:7154/api/Subtraction?";
            string x = textBox1.Text;
            string y = textBox2.Text;

            if(Convert.ToInt32(y) == 0)
            {
                MessageBox.Show("ERROR","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            url += "x=" + x + "&y=" + y;

            OpenUrl(url);
        }
    }
}