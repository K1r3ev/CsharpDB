namespace WindowsFormsApp1
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remontDataSet = new WindowsFormsApp1.RemontDataSet();
            this.rEQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEQUESTTableAdapter = new WindowsFormsApp1.RemontDataSetTableAdapters.REQUESTTableAdapter();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dbname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.PictureBox();
            this.shortdescrppanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxclient = new System.Windows.Forms.TextBox();
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxresp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcom = new System.Windows.Forms.TextBox();
            this.textBox_exec = new System.Windows.Forms.TextBox();
            this.labexec = new System.Windows.Forms.Label();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_descrip = new System.Windows.Forms.TextBox();
            this.textBox_typeoffail = new System.Windows.Forms.TextBox();
            this.textBox_equimp = new System.Windows.Forms.TextBox();
            this.textbox_num = new System.Windows.Forms.TextBox();
            this.labdesctip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Typeoffail = new System.Windows.Forms.Label();
            this.labequimp = new System.Windows.Forms.Label();
            this.labnum = new System.Windows.Forms.Label();
            this.shortdescrp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).BeginInit();
            this.controlpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            this.shortdescrppanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // remontDataSet
            // 
            this.remontDataSet.DataSetName = "RemontDataSet";
            this.remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEQUESTBindingSource
            // 
            this.rEQUESTBindingSource.DataMember = "REQUEST";
            this.rEQUESTBindingSource.DataSource = this.remontDataSet;
            // 
            // rEQUESTTableAdapter
            // 
            this.rEQUESTTableAdapter.ClearBeforeFill = true;
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlpanel.Controls.Add(this.pictureBox2);
            this.controlpanel.Controls.Add(this.pictureBox1);
            this.controlpanel.Controls.Add(this.Dbname);
            this.controlpanel.Controls.Add(this.textBox1);
            this.controlpanel.Controls.Add(this.deletebtn);
            this.controlpanel.Location = new System.Drawing.Point(12, 7);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(1329, 46);
            this.controlpanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(866, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 46);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(793, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 46);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dbname
            // 
            this.Dbname.AutoSize = true;
            this.Dbname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbname.Location = new System.Drawing.Point(15, 14);
            this.Dbname.Name = "Dbname";
            this.Dbname.Size = new System.Drawing.Size(298, 20);
            this.Dbname.TabIndex = 4;
            this.Dbname.Text = "База данных заявок на ремонт";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(939, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // deletebtn
            // 
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletebtn.Location = new System.Drawing.Point(720, 0);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(67, 46);
            this.deletebtn.TabIndex = 0;
            this.deletebtn.TabStop = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // shortdescrppanel
            // 
            this.shortdescrppanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.shortdescrppanel.Controls.Add(this.label5);
            this.shortdescrppanel.Controls.Add(this.textBoxclient);
            this.shortdescrppanel.Controls.Add(this.textBoxdate);
            this.shortdescrppanel.Controls.Add(this.label4);
            this.shortdescrppanel.Controls.Add(this.label3);
            this.shortdescrppanel.Controls.Add(this.textBoxresp);
            this.shortdescrppanel.Controls.Add(this.label2);
            this.shortdescrppanel.Controls.Add(this.textBoxcom);
            this.shortdescrppanel.Controls.Add(this.textBox_exec);
            this.shortdescrppanel.Controls.Add(this.labexec);
            this.shortdescrppanel.Controls.Add(this.textBox_status);
            this.shortdescrppanel.Controls.Add(this.textBox_descrip);
            this.shortdescrppanel.Controls.Add(this.textBox_typeoffail);
            this.shortdescrppanel.Controls.Add(this.textBox_equimp);
            this.shortdescrppanel.Controls.Add(this.textbox_num);
            this.shortdescrppanel.Controls.Add(this.labdesctip);
            this.shortdescrppanel.Controls.Add(this.label1);
            this.shortdescrppanel.Controls.Add(this.Typeoffail);
            this.shortdescrppanel.Controls.Add(this.labequimp);
            this.shortdescrppanel.Controls.Add(this.labnum);
            this.shortdescrppanel.Controls.Add(this.shortdescrp);
            this.shortdescrppanel.Location = new System.Drawing.Point(12, 455);
            this.shortdescrppanel.Name = "shortdescrppanel";
            this.shortdescrppanel.Size = new System.Drawing.Size(1126, 258);
            this.shortdescrppanel.TabIndex = 2;
            this.shortdescrppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.shortdescrppanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(646, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Клиент";
            // 
            // textBoxclient
            // 
            this.textBoxclient.Location = new System.Drawing.Point(533, 170);
            this.textBoxclient.Name = "textBoxclient";
            this.textBoxclient.Size = new System.Drawing.Size(291, 20);
            this.textBoxclient.TabIndex = 24;
            // 
            // textBoxdate
            // 
            this.textBoxdate.Location = new System.Drawing.Point(533, 227);
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.Size = new System.Drawing.Size(291, 20);
            this.textBoxdate.TabIndex = 23;
            this.textBoxdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(646, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Дата ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(623, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Отвественный";
            // 
            // textBoxresp
            // 
            this.textBoxresp.Location = new System.Drawing.Point(533, 117);
            this.textBoxresp.Name = "textBoxresp";
            this.textBoxresp.Size = new System.Drawing.Size(291, 20);
            this.textBoxresp.TabIndex = 20;
            this.textBoxresp.TextChanged += new System.EventHandler(this.textBoxresp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(957, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Комментарий";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxcom
            // 
            this.textBoxcom.Location = new System.Drawing.Point(904, 53);
            this.textBoxcom.Multiline = true;
            this.textBoxcom.Name = "textBoxcom";
            this.textBoxcom.Size = new System.Drawing.Size(202, 202);
            this.textBoxcom.TabIndex = 18;
            // 
            // textBox_exec
            // 
            this.textBox_exec.Location = new System.Drawing.Point(533, 53);
            this.textBox_exec.Name = "textBox_exec";
            this.textBox_exec.Size = new System.Drawing.Size(291, 20);
            this.textBox_exec.TabIndex = 17;
            this.textBox_exec.TextChanged += new System.EventHandler(this.textBox_exec_TextChanged);
            // 
            // labexec
            // 
            this.labexec.AutoSize = true;
            this.labexec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labexec.Location = new System.Drawing.Point(623, 34);
            this.labexec.Name = "labexec";
            this.labexec.Size = new System.Drawing.Size(94, 16);
            this.labexec.TabIndex = 16;
            this.labexec.Text = "Исполнитель";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(109, 230);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(412, 20);
            this.textBox_status.TabIndex = 15;
            // 
            // textBox_descrip
            // 
            this.textBox_descrip.Location = new System.Drawing.Point(84, 138);
            this.textBox_descrip.Multiline = true;
            this.textBox_descrip.Name = "textBox_descrip";
            this.textBox_descrip.Size = new System.Drawing.Size(437, 86);
            this.textBox_descrip.TabIndex = 14;
            this.textBox_descrip.TextChanged += new System.EventHandler(this.textBox_descrip_TextChanged);
            // 
            // textBox_typeoffail
            // 
            this.textBox_typeoffail.Location = new System.Drawing.Point(109, 111);
            this.textBox_typeoffail.Name = "textBox_typeoffail";
            this.textBox_typeoffail.Size = new System.Drawing.Size(412, 20);
            this.textBox_typeoffail.TabIndex = 13;
            this.textBox_typeoffail.TextChanged += new System.EventHandler(this.textBox_typeoffail_TextChanged);
            // 
            // textBox_equimp
            // 
            this.textBox_equimp.Location = new System.Drawing.Point(109, 85);
            this.textBox_equimp.Name = "textBox_equimp";
            this.textBox_equimp.Size = new System.Drawing.Size(412, 20);
            this.textBox_equimp.TabIndex = 12;
            // 
            // textbox_num
            // 
            this.textbox_num.Location = new System.Drawing.Point(109, 53);
            this.textbox_num.Name = "textbox_num";
            this.textbox_num.Size = new System.Drawing.Size(412, 20);
            this.textbox_num.TabIndex = 11;
            this.textbox_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_num.TextChanged += new System.EventHandler(this.textbox_num_TextChanged);
            // 
            // labdesctip
            // 
            this.labdesctip.AutoSize = true;
            this.labdesctip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labdesctip.Location = new System.Drawing.Point(3, 138);
            this.labdesctip.Name = "labdesctip";
            this.labdesctip.Size = new System.Drawing.Size(75, 16);
            this.labdesctip.TabIndex = 10;
            this.labdesctip.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Статус";
            // 
            // Typeoffail
            // 
            this.Typeoffail.AutoSize = true;
            this.Typeoffail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Typeoffail.Location = new System.Drawing.Point(3, 111);
            this.Typeoffail.Name = "Typeoffail";
            this.Typeoffail.Size = new System.Drawing.Size(91, 16);
            this.Typeoffail.TabIndex = 8;
            this.Typeoffail.Text = "Тип поломки";
            // 
            // labequimp
            // 
            this.labequimp.AutoSize = true;
            this.labequimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labequimp.Location = new System.Drawing.Point(3, 83);
            this.labequimp.Name = "labequimp";
            this.labequimp.Size = new System.Drawing.Size(105, 16);
            this.labequimp.TabIndex = 7;
            this.labequimp.Text = "Оборудование";
            this.labequimp.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labnum
            // 
            this.labnum.AutoSize = true;
            this.labnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labnum.Location = new System.Drawing.Point(3, 53);
            this.labnum.Name = "labnum";
            this.labnum.Size = new System.Drawing.Size(99, 16);
            this.labnum.TabIndex = 6;
            this.labnum.Text = "Номер заявки";
            // 
            // shortdescrp
            // 
            this.shortdescrp.AutoSize = true;
            this.shortdescrp.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortdescrp.Location = new System.Drawing.Point(30, 11);
            this.shortdescrp.Name = "shortdescrp";
            this.shortdescrp.Size = new System.Drawing.Size(248, 20);
            this.shortdescrp.TabIndex = 5;
            this.shortdescrp.Text = "Краткое описание заявки";
            this.shortdescrp.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(1141, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(3, 399);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(194, 64);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Добавить новую заявку";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 587);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "Статистика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shortdescrppanel);
            this.Controls.Add(this.controlpanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).EndInit();
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            this.shortdescrppanel.ResumeLayout(false);
            this.shortdescrppanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RemontDataSet remontDataSet;
        private System.Windows.Forms.BindingSource rEQUESTBindingSource;
        private RemontDataSetTableAdapters.REQUESTTableAdapter rEQUESTTableAdapter;
        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Label Dbname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox deletebtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel shortdescrppanel;
        private System.Windows.Forms.Label shortdescrp;
        private System.Windows.Forms.Label labnum;
        private System.Windows.Forms.Label labequimp;
        private System.Windows.Forms.Label Typeoffail;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.TextBox textBox_descrip;
        private System.Windows.Forms.TextBox textBox_typeoffail;
        private System.Windows.Forms.TextBox textBox_equimp;
        private System.Windows.Forms.TextBox textbox_num;
        private System.Windows.Forms.Label labdesctip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_exec;
        private System.Windows.Forms.Label labexec;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox textBoxcom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxresp;
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxclient;
        private System.Windows.Forms.Button button2;
    }
}