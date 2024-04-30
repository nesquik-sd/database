using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_session
{
    public partial class Faculties_Form : Form
    {
        public Faculties_Form()
        {
            InitializeComponent();
        }


        private void First_Faculty_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses_Form f3 = new Courses_Form(1);
            f3.Show();
            Visible = false;
            
        }

        private void Second_Faculty_Button_Click(object sender, EventArgs e)
        {
            Courses_Form f3 = new Courses_Form(2);
            f3.Show();
            Visible = false;
        }

        private void Third_Faculty_Button_Click(object sender, EventArgs e)
        {
            Courses_Form f3 = new Courses_Form(3);
            f3.Show();
            Visible = false;
        }

        private void Fourth_Faculty_Button_Click(object sender, EventArgs e)
        {
            Courses_Form f3 = new Courses_Form(4);
            f3.Show();
            Visible = false;
        }

        private void Fifth_Faculty_Button_Click(object sender, EventArgs e)
        {
            Courses_Form f3 = new Courses_Form(5);
            f3.Show();
            Visible = false;
        }

        private void Sixth_Faculty_Button_Click(object sender, EventArgs e)
        {
            Courses_Form f3 = new Courses_Form(6);
            f3.Show();
            Visible = false;
        }
    }
}
