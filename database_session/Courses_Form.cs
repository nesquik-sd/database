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
    public partial class Courses_Form : Form
    {
        public Courses_Form()
        {
            InitializeComponent();
        }

        
        private void First_Coutse_Button_Click(object sender, EventArgs e)
        {
            Courses_Form f3 = new Courses_Form();
            //f3.Show();
            DialogResult result = f3.ShowDialog();
            if (result == DialogResult.OK)
            {
                Result_Form f4 = new Result_Form();
                //Courses_Form f3 = new Courses_Form();
                f4.Show();
                Visible = false;
            }
            else
            {
                Timetable_Form f5 = new Timetable_Form();
                f5.Show();
                Visible = false;
            }
        }
    }
}
