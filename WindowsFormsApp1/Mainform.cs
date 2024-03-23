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
using System.Data.SqlTypes;
using System.Reflection;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
namespace WindowsFormsApp1
{
    enum RowState
    {
        Existed,
        New,
        Deleted,
        Modified,
        ModifiedNew,
    }

    public partial class Mainform : Form
    {
        DataBase dataBase = new DataBase();
        int SelectedRow;

        public Mainform()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            MaximizeBox = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addform addform = new addform();
            addform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("Stage", "Статус");
            dataGridView1.Columns.Add("Responsible", "Ответственный");
            dataGridView1.Columns.Add("executor", "Исполнитель");
            dataGridView1.Columns.Add("Fail", "Тип поломки");
            dataGridView1.Columns.Add("Client", "Клиент");
            dataGridView1.Columns.Add("Equipment", "Оборудование");
            dataGridView1.Columns.Add("created_date", "Время создания");
            dataGridView1.Columns.Add("Comment", "Комментарий");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

           private void ClearFields()
        {

            textbox_num.Text = "";
            textBox_equimp.Text = "";
            textBox_typeoffail.Text = "";
            textBox_descrip.Text = "";
            textBox_status.Text = "";
            textBox_exec.Text = "";
            textBoxcom.Text = "";
            textBoxclient.Text = "";
            textBoxresp.Text = "";
            textBoxdate.Text = "";
        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8), record.GetString(9), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from REQUEST";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;

            if (SelectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];

                textbox_num.Text = row.Cells[0].Value.ToString();
                textBox_equimp.Text = row.Cells[7].Value.ToString();
                textBox_typeoffail.Text = row.Cells[5].Value.ToString();
                textBox_descrip.Text = row.Cells[1].Value.ToString();
                textBox_status.Text = row.Cells[2].Value.ToString();
                textBox_exec.Text = row.Cells[4].Value.ToString();
                textBoxcom.Text = row.Cells[9].Value.ToString();
                textBoxclient.Text = row.Cells[6].Value.ToString();
                textBoxresp.Text = row.Cells[3].Value.ToString();
                textBoxdate.Text = row.Cells[8].Value.ToString();
                
            }
        }

        private void Search(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string searchString = $"select * from REQUEST where concat (id,Description,Stage,Responsible,executor, Fail, Client, Equipment,created_date, Comment) like '%" + textBox1.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {

                ReadSingleRow(dgw, reader);

            }

            reader.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void DeleteRow()
        {

            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;

            return;
        }

        private void Update()
        {

            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[10].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from REQUEST where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified) 
                {
                
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var descrip = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var stage = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var fail = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var exec = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var respon = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var client = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var equimp = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    var comment = dataGridView1.Rows[index].Cells[9].Value.ToString();

                    var changeQuery = $"update REQUEST set Description = '{descrip}', stage = '{stage}',Fail = '{fail}',executor = '{exec}',Responsible = '{respon}',Client = '{client}',Equipment = '{equimp}',created_date = '{date}', Comment = '{comment}' where id = '{id}'";

                    var command = new SqlCommand (changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }

               
            }
            dataBase.closeConnection();
        }
        private void shortdescrppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();


        }


        private void Change()
        {

            var selectedRowindex = dataGridView1.CurrentCell.RowIndex;
            var id =  textbox_num.Text;
            var respon1 = textBoxresp.Text;
            var equimp1 =textBox_equimp.Text;
            var date1 =textBoxdate.Text;
            var decrib = textBox_descrip.Text;
            var fail = textBox_typeoffail.Text;
            var execute = textBox_exec.Text;
            var comment = textBoxcom.Text;
            var stage = textBox_status.Text;
            var client = textBoxclient.Text;


            dataGridView1.Rows[selectedRowindex].SetValues(id,decrib,stage,respon1,execute,fail,client,equimp1,date1,comment);
            dataGridView1.Rows[selectedRowindex].Cells[10].Value = RowState.Modified;
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();


        }

        private void textbox_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_descrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_exec_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_typeoffail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxresp_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
