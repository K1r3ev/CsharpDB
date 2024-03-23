using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1

{
    public partial class Login : Form

    {
        DataBase database = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userlogin = textlog.Text;
            var userpass = textpass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet table = new DataSet();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{userlogin}' and password_user = '{userpass}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Tables[0].Rows.Count == 1)
            {
                // авторизация прошла успешно
                MessageBox.Show("Авторизация прошла успешно!");
                this.Hide();
                Mainform mainForm = new Mainform();
                mainForm.Show();
            }
            else
            {
                // авторизация не удалась
                MessageBox.Show("Логин или пароль указан неверно!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            textpass.PasswordChar = '*';
        }
    }
}

