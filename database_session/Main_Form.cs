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
            Results_Button.DialogResult = DialogResult.OK;
            Timetable_Button.DialogResult = DialogResult.Cancel;
        }

        private void Results_Button_Click(object sender, EventArgs e)
        {
            Faculties_Form f2 = new Faculties_Form();
            f2.Show();
            Visible = false;
            //f2.ShowDialog();
        }

        private void Timetable_Button_Click(object sender, EventArgs e)
        {
            Faculties_Form f2 = new Faculties_Form();
            f2.Show();
            Visible = false;

        }
    }
}
