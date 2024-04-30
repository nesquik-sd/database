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
        private int number_faculty;
        public Courses_Form(int number_faculty)
        {
            InitializeComponent();
            this.number_faculty = number_faculty;
        }

        public void Form_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static bool Result_Clicked = false; //для проверки, были нажаты результаты или расписание

       
        private void First_Coutse_Button_Click(object sender, EventArgs e) 
        {

            if (Result_Clicked)
            {
                Result_Form f4 = new Result_Form(number_faculty, 1); 
                f4.Show();
                Visible = false;
            }
            else
            {
                this.Hide();
                Timetable_Form f5 = new Timetable_Form(number_faculty, 1);
                f5.Show();
                Visible = false;
            }
        }

        private void Second_Coutse_Button_Click(object sender, EventArgs e)
        {
            if (Result_Clicked)
            {
                Result_Form f4 = new Result_Form(number_faculty, 2);
                f4.Show();
                Visible = false;
            }
            else
            {
                Timetable_Form f5 = new Timetable_Form(number_faculty, 2);
                f5.Show();
                Visible = false;
            }
        }

        private void Third_Coutse_Button_Click(object sender, EventArgs e)
        {
            if (Result_Clicked)
            {
                Result_Form f4 = new Result_Form(number_faculty, 3);
                f4.Show();
                Visible = false;
            }
            else
            {
                Timetable_Form f5 = new Timetable_Form(number_faculty, 3);
                f5.Show();
                Visible = false;
            }
        }
        
        private void Fourth_Coutse_Button_Click(object sender, EventArgs e)
        {
            if (Result_Clicked)
            {
                Result_Form f4 = new Result_Form(number_faculty, 4);
                f4.Show();
                Visible = false;
            }
            else
            {
                Timetable_Form f5 = new Timetable_Form(number_faculty, 4);
                f5.Show();
                Visible = false;
            }
        }


    }
}
