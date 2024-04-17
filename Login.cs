using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence_Student
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Redirect to Page1
                Student page1 = new Student();
                page1.Show();
            }
            else if (radioButton2.Checked)
            {
                // Redirect to Page2
                Teacher page2 = new Teacher();
                page2.Show();
            }
            else if (radioButton3.Checked)
            {
                // Redirect to Page3
                Admin page3 = new Admin();
                page3.Show();
            }
            else
            {
                MessageBox.Show("Please select an option before proceeding.");
            }
        }
    }
}
