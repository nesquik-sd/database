using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace database_session
{
    public partial class Timetable_Form : Form
    {
        private int number_course;
        private int number_faculty;
        private bool admin = false;
        public Timetable_Form(int number_faculty, int number_course)
        {
            InitializeComponent();
            this.number_faculty = number_faculty;
            this.number_course = number_course;
        }

 

        public void Form_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public  bool Who_Autorizating(string login, string password)
        {
            if ((!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password)) && (login == "root" && password == "root"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  string Get_User(bool success_admin)
        {
            if (success_admin)
            {
                return "server = localhost; port = 8889; username = root; password = root; database = session";
            }
            else
            {
                return "server = localhost; port = 8889; username = user; password = u; database = session";
            }
        }
        private void Log_Like_Admin_Button_Click(object sender, EventArgs e)
        {
            string log = Login_Text_Box.Text;
            string pas = Password_Text_Box.Text;
            bool check_admin = Who_Autorizating(log, pas);
            if (check_admin)
            {
                MessageBox.Show("Вы вошли как администратор");

                admin = true;
            }
            else
            {
                MessageBox.Show("Неверные данные администратора");
                admin= false;
            }


        }

        public System.Data.DataSet ds;
        private void Timetable_Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Нажата кнопка: {number_faculty}, {number_course} ");
            /*string command = "SELECT * FROM `timetable`  WHERE `факультет` = @f AND `курс` = @n";
           // MySqcommand.Parameters.Add("@f", MySqlDbType)
            string connect = "server = localhost; port = 3306; username = root; password = root; database = session";
            MySqlConnection connection = new MySqlConnection(connect);


            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, connect);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            data_view_timetable.DataSource = table;
            connection.Close();*/

            /*string get_connection = Get_User(admin);
            // MySqlConnection connection = new MySqlConnection("server = localhost; port = 8889; username = root; password = root; database = session");
            MySqlConnection connection = new MySqlConnection(get_connection);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }*/

            /*Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // MySqlCommand command = new MySqlCommand("SELECT * FROM `groups`  WHERE факультет = @f AND курс = @c", database.Get_Connection());
            // MySqlCommand command = new MySqlCommand("SELECT t.* FROM timetable t JOIN groups g ON t.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c", database.Get_Connection());
            MySqlCommand command = new MySqlCommand("SELECT t.* FROM timetable t JOIN groups g ON t.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c", connection);
            command.Parameters.Add("@f", MySqlDbType.Int32).Value = number_faculty;
            command.Parameters.Add("@c", MySqlDbType.Int32).Value = number_course;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            data_view_timetable.DataSource = table;*/
            //command.Parameters.Add("@f")
           // Autorization_Form.Who_Autorizating
        }

        private void Connection_Button_Click(object sender, EventArgs e)
        {
            string get_connection = Get_User(admin);
            MySqlConnection connection = new MySqlConnection(get_connection);
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MessageBox.Show("Соединение переподключено - " + get_connection);
            }
            catch {
                MessageBox.Show("Ошибка");
            }

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // MySqlCommand command = new MySqlCommand("SELECT * FROM `groups`  WHERE факультет = @f AND курс = @c", database.Get_Connection());
            // MySqlCommand command = new MySqlCommand("SELECT t.* FROM timetable t JOIN groups g ON t.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c", database.Get_Connection());
           
            MySqlCommand command = new MySqlCommand("SELECT t.* FROM timetable t JOIN groups g ON t.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c", connection);
            command.Parameters.Add("@f", MySqlDbType.Int32).Value = number_faculty;
            command.Parameters.Add("@c", MySqlDbType.Int32).Value = number_course;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            data_view_timetable.DataSource = table;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                MessageBox.Show("Могете");
                //string query2 = "INSERT INTO timetable(id_сдачи, предмет, тип_сдачи, дата, номер_группы) VALUES(2, 'Программирование', 'Экзамен', '2024-01-24', '424')";
                //  string get_connection = Get_User(admin);
                // MySqlConnection connection = new MySqlConnection(get_connection);
                // MySqlCommand command = new MySqlCommand(query2, connection);
                // выполняем запрос
                // command.ExecuteNonQuery();
                string sql = "SELECT t.* FROM timetable t JOIN groups g ON t.номер_группы = g.номер_группы WHERE g.факультет = @f AND g.курс = @c";


                string get_connection = Get_User(admin);
                MySqlConnection connection = new MySqlConnection(get_connection);
                connection.Open();

                /* MySqlDataAdapter adapter = new MySqlDataAdapter (sql, connection);
                 MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                 adapter.InsertCommand = new MySqlCommand("sp_CreateUser", connection);
                 adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                 adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                 adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 0, "Age"));

                 MySqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", MySqlDbType.Int32, 0, "Id");
                 parameter.Direction = ParameterDirection.Output;

                 adapter.Update(ds);*/
                //DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
               // ds.Tables[0].Rows.Add(row);

            } else
            {
                MessageBox.Show("Вы всего лишь юзер");
            }
        }
    }
}
