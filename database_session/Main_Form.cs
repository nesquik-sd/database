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
    public partial class Mainn_Form : Form
    {
        public Mainn_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Results_Button.DialogResult = DialogResult.OK;
           // Timetable_Button.DialogResult = DialogResult.Cancel;
        }

  

        private void Result_Click(object sender, EventArgs e)
        {
            Courses_Form.Result_Clicked = true;
        }

        private void Results_Button_Click(object sender, EventArgs e)
        {
            Faculties_Form f2 = new Faculties_Form();
            f2.Show();
            Visible = false;
            //f2.ShowDialog();
            Courses_Form.Result_Clicked = true;
            
        }

        private void Timetable_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculties_Form f2 = new Faculties_Form();
            f2.Show();
            Visible = false;
            Courses_Form.Result_Clicked = false;

        }
        public void Subscribe_To_Button(EventHandler eh)
        {
            Results_Button.Click += eh;
        }
    }
}
