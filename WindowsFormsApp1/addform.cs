using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
namespace WindowsFormsApp1
{
    
    public partial class addform : Form
    {
        DataBase dataBase = new DataBase();
        public addform()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var equipment = textBoxequim.Text;
            var fail = textBoxfail.Text;
            var decription = textBoxdecrip.Text;
            var client = textBoxclient.Text;
            var executer = textBoxexec.Text;
            var resposible = textBoxrespon.Text;
            var stage = "ожидание";
            var date = maskedTextBox1.Text;
            var com = textBoxcom1.Text;

            var Addquery = $"INSERT INTO REQUEST(Description,Stage,Responsible,executor, Fail, Client, Equipment,created_date,Comment) values ('{decription}','{stage}','{resposible}','{executer}','{fail}','{client}','{equipment}','{date}','{com}')";
            

            var command = new SqlCommand(Addquery, dataBase.GetConnection());
            

            command.ExecuteNonQuery();
         

            MessageBox.Show("Заявка создана!");
            this.Hide();

            dataBase.closeConnection();
        }
       
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addform_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
