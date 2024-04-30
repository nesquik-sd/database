using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace database_session
{
    public partial class Result_Form : Form
    {
        private int number_course;
        private int number_faculty;
        public Result_Form(int number_faculty, int number_course)
        {
            InitializeComponent();
            this.number_faculty= number_faculty;
            this.number_course = number_course;
        }


        public System.Data.DataSet ds;

        private void Result_Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Нажата кнопка: {number_faculty}, {number_course} ");
            MySqlConnection connection = new MySqlConnection("server = localhost; port = 8889; username = root; password = root; database = session");
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();


            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // MySqlCommand command = new MySqlCommand("SELECT * FROM `results`  WHERE факультет = @f AND курс = @c", database.Get_Connection());
            // command.Parameters.Add("@f", MySqlDbType.Int32).Value = number_faculty;
            // command.Parameters.Add("@c", MySqlDbType.Int32).Value = number_course;
            // MySqlCommand command = new MySqlCommand("SELECT r.* FROM results r JOIN students s ON r.номер_зачётки = s.номер_зачётки JOIN groups g ON s.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c", database.Get_Connection());
            MySqlCommand command = new MySqlCommand("SELECT r.* FROM results r JOIN students s ON r.номер_зачётки = s.номер_зачётки JOIN groups g ON s.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c", connection);

            command.Parameters.Add("@f", MySqlDbType.Int32).Value = number_faculty;
            command.Parameters.Add("@c", MySqlDbType.Int32).Value = number_course;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            data_view_results.DataSource = table;
           

        }

       

       
    }
}

