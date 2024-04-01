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
            Courses_Form f3 = new Courses_Form();
            f3.Show();
            Visible = false;
            
        }
    }
}
