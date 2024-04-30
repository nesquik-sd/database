using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database_session;
using MySql.Data.MySqlClient;


namespace database_session
{
    public partial class Autorization_Form : Form
    {
        public Autorization_Form()
        {
            InitializeComponent();
        }

        private void Login_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        public static bool Who_Autorizating(string login, string password)
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

        public static string Get_User(bool success_admin)
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

        public  string Get_Login()
        {
            return Login_Text_Box.Text;
        }

        public void Login_Button_Click(object sender, EventArgs e)
        {

            string log = Login_Text_Box.Text;
            string pas = Password_Text_Box.Text;
            bool check_admin = Who_Autorizating(log, pas);
            if (check_admin)
            {
                MessageBox.Show("Вы вошли как администратор");
            } else
            {
                MessageBox.Show("Неверный пароль администратора");
            }
        }
    }
}
