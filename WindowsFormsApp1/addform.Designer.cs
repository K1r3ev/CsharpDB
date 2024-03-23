namespace WindowsFormsApp1
{
    partial class addform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dbname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeleq = new System.Windows.Forms.Label();
            this.labelfail = new System.Windows.Forms.Label();
            this.labeldecri = new System.Windows.Forms.Label();
            this.labelclient = new System.Windows.Forms.Label();
            this.textBoxequim = new System.Windows.Forms.TextBox();
            this.textBoxfail = new System.Windows.Forms.TextBox();
            this.textBoxdecrip = new System.Windows.Forms.TextBox();
            this.textBoxclient = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxexec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxrespon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxcom1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Dbname);
            this.panel1.Location = new System.Drawing.Point(176, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 100);
            this.panel1.TabIndex = 0;
            // 
            // Dbname
            // 
            this.Dbname.AutoSize = true;
            this.Dbname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbname.Location = new System.Drawing.Point(76, 38);
            this.Dbname.Name = "Dbname";
            this.Dbname.Size = new System.Drawing.Size(230, 20);
            this.Dbname.TabIndex = 5;
            this.Dbname.Text = "Создание новой заявки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labeleq
            // 
            this.labeleq.AutoSize = true;
            this.labeleq.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleq.Location = new System.Drawing.Point(56, 162);
            this.labeleq.Name = "labeleq";
            this.labeleq.Size = new System.Drawing.Size(143, 20);
            this.labeleq.TabIndex = 6;
            this.labeleq.Text = "Оборудование";
            this.labeleq.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelfail
            // 
            this.labelfail.AutoSize = true;
            this.labelfail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfail.Location = new System.Drawing.Point(12, 198);
            this.labelfail.Name = "labelfail";
            this.labelfail.Size = new System.Drawing.Size(187, 20);
            this.labelfail.TabIndex = 7;
            this.labelfail.Text = "Тип неисправности";
            // 
            // labeldecri
            // 
            this.labeldecri.AutoSize = true;
            this.labeldecri.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldecri.Location = new System.Drawing.Point(2, 235);
            this.labeldecri.Name = "labeldecri";
            this.labeldecri.Size = new System.Drawing.Size(197, 20);
            this.labeldecri.TabIndex = 8;
            this.labeldecri.Text = "Описание проблемы";
            // 
            // labelclient
            // 
            this.labelclient.AutoSize = true;
            this.labelclient.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclient.Location = new System.Drawing.Point(86, 261);
            this.labelclient.Name = "labelclient";
            this.labelclient.Size = new System.Drawing.Size(73, 20);
            this.labelclient.TabIndex = 9;
            this.labelclient.Text = "Клиент";
            // 
            // textBoxequim
            // 
            this.textBoxequim.Location = new System.Drawing.Point(205, 150);
            this.textBoxequim.Multiline = true;
            this.textBoxequim.Name = "textBoxequim";
            this.textBoxequim.Size = new System.Drawing.Size(343, 32);
            this.textBoxequim.TabIndex = 14;
            // 
            // textBoxfail
            // 
            this.textBoxfail.Location = new System.Drawing.Point(205, 191);
            this.textBoxfail.Multiline = true;
            this.textBoxfail.Name = "textBoxfail";
            this.textBoxfail.Size = new System.Drawing.Size(343, 27);
            this.textBoxfail.TabIndex = 15;
            // 
            // textBoxdecrip
            // 
            this.textBoxdecrip.Location = new System.Drawing.Point(205, 224);
            this.textBoxdecrip.Multiline = true;
            this.textBoxdecrip.Name = "textBoxdecrip";
            this.textBoxdecrip.Size = new System.Drawing.Size(343, 31);
            this.textBoxdecrip.TabIndex = 16;
            // 
            // textBoxclient
            // 
            this.textBoxclient.Location = new System.Drawing.Point(205, 261);
            this.textBoxclient.Multiline = true;
            this.textBoxclient.Name = "textBoxclient";
            this.textBoxclient.Size = new System.Drawing.Size(343, 29);
            this.textBoxclient.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(555, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 61);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxexec
            // 
            this.textBoxexec.Location = new System.Drawing.Point(205, 296);
            this.textBoxexec.Multiline = true;
            this.textBoxexec.Name = "textBoxexec";
            this.textBoxexec.Size = new System.Drawing.Size(343, 29);
            this.textBoxexec.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Исполнитель";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxrespon
            // 
            this.textBoxrespon.Location = new System.Drawing.Point(205, 331);
            this.textBoxrespon.Multiline = true;
            this.textBoxrespon.Name = "textBoxrespon";
            this.textBoxrespon.Size = new System.Drawing.Size(343, 29);
            this.textBoxrespon.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Отвественный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дата";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(201, 368);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(347, 20);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxcom1
            // 
            this.textBoxcom1.Location = new System.Drawing.Point(572, 164);
            this.textBoxcom1.Multiline = true;
            this.textBoxcom1.Name = "textBoxcom1";
            this.textBoxcom1.Size = new System.Drawing.Size(216, 187);
            this.textBoxcom1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Комментарий";
            // 
            // addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxcom1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxrespon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxexec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxclient);
            this.Controls.Add(this.textBoxdecrip);
            this.Controls.Add(this.textBoxfail);
            this.Controls.Add(this.textBoxequim);
            this.Controls.Add(this.labelclient);
            this.Controls.Add(this.labeldecri);
            this.Controls.Add(this.labelfail);
            this.Controls.Add(this.labeleq);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "addform";
            this.Text = "pa";
            this.Load += new System.EventHandler(this.addform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Dbname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeleq;
        private System.Windows.Forms.Label labelfail;
        private System.Windows.Forms.Label labeldecri;
        private System.Windows.Forms.Label labelclient;
        private System.Windows.Forms.TextBox textBoxequim;
        private System.Windows.Forms.TextBox textBoxfail;
        private System.Windows.Forms.TextBox textBoxdecrip;
        private System.Windows.Forms.TextBox textBoxclient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxexec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxrespon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBoxcom1;
        private System.Windows.Forms.Label label4;
    }
}