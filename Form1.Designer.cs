namespace paperplease_visual
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BirthDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gMname = new System.Windows.Forms.TextBox();
            this.gFname = new System.Windows.Forms.TextBox();
            this.gLname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.acceptedTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deniedTable = new System.Windows.Forms.DataGridView();
            this.Button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.accepted_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accepted_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accepted_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denied_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denied_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denied_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspectTable = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.suspect_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspect_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspect_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabuCity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deniedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspectTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.mname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BirthDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите паспортные данные";
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(120, 20);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(360, 22);
            this.BirthDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Город";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(120, 50);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(360, 22);
            this.lname.TabIndex = 7;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(120, 80);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(360, 22);
            this.fname.TabIndex = 8;
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(120, 110);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(360, 22);
            this.mname.TabIndex = 9;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(120, 140);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(360, 22);
            this.city.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Button);
            this.groupBox2.Controls.Add(this.gMname);
            this.groupBox2.Controls.Add(this.gFname);
            this.groupBox2.Controls.Add(this.gLname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.gAge);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(506, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 176);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите полученные данные";
            // 
            // gMname
            // 
            this.gMname.Location = new System.Drawing.Point(120, 110);
            this.gMname.Name = "gMname";
            this.gMname.Size = new System.Drawing.Size(360, 22);
            this.gMname.TabIndex = 9;
            // 
            // gFname
            // 
            this.gFname.Location = new System.Drawing.Point(120, 80);
            this.gFname.Name = "gFname";
            this.gFname.Size = new System.Drawing.Size(360, 22);
            this.gFname.TabIndex = 8;
            // 
            // gLname
            // 
            this.gLname.Location = new System.Drawing.Point(120, 50);
            this.gLname.Name = "gLname";
            this.gLname.Size = new System.Drawing.Size(360, 22);
            this.gLname.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Отчество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Имя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Фамилия";
            // 
            // gAge
            // 
            this.gAge.Location = new System.Drawing.Point(120, 20);
            this.gAge.Name = "gAge";
            this.gAge.Size = new System.Drawing.Size(360, 22);
            this.gAge.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Возраст";
            // 
            // acceptedTable
            // 
            this.acceptedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.acceptedTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.acceptedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accepted_birth,
            this.accepted_name,
            this.accepted_city});
            this.acceptedTable.Location = new System.Drawing.Point(12, 260);
            this.acceptedTable.Name = "acceptedTable";
            this.acceptedTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.acceptedTable.RowTemplate.Height = 24;
            this.acceptedTable.Size = new System.Drawing.Size(325, 449);
            this.acceptedTable.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Доступ разрешен";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Доступ запрещен";
            // 
            // deniedTable
            // 
            this.deniedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deniedTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.deniedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deniedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denied_birth,
            this.denied_name,
            this.denied_city});
            this.deniedTable.Location = new System.Drawing.Point(343, 260);
            this.deniedTable.Name = "deniedTable";
            this.deniedTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.deniedTable.RowTemplate.Height = 24;
            this.deniedTable.Size = new System.Drawing.Size(325, 449);
            this.deniedTable.TabIndex = 15;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(405, 140);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 10;
            this.Button.Text = "Внести";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Готов заплатить?";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(140, 140);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 12;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // accepted_birth
            // 
            this.accepted_birth.HeaderText = "Дата рождения";
            this.accepted_birth.MinimumWidth = 6;
            this.accepted_birth.Name = "accepted_birth";
            // 
            // accepted_name
            // 
            this.accepted_name.HeaderText = "ФИО";
            this.accepted_name.MinimumWidth = 6;
            this.accepted_name.Name = "accepted_name";
            // 
            // accepted_city
            // 
            this.accepted_city.HeaderText = "Город";
            this.accepted_city.MinimumWidth = 6;
            this.accepted_city.Name = "accepted_city";
            // 
            // denied_birth
            // 
            this.denied_birth.HeaderText = "Дата рождения";
            this.denied_birth.MinimumWidth = 6;
            this.denied_birth.Name = "denied_birth";
            // 
            // denied_name
            // 
            this.denied_name.HeaderText = "ФИО";
            this.denied_name.MinimumWidth = 6;
            this.denied_name.Name = "denied_name";
            // 
            // denied_city
            // 
            this.denied_city.HeaderText = "Город";
            this.denied_city.MinimumWidth = 6;
            this.denied_city.Name = "denied_city";
            // 
            // suspectTable
            // 
            this.suspectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suspectTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.suspectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suspectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suspect_birth,
            this.suspect_name,
            this.suspect_city});
            this.suspectTable.Location = new System.Drawing.Point(674, 260);
            this.suspectTable.Name = "suspectTable";
            this.suspectTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.suspectTable.RowTemplate.Height = 24;
            this.suspectTable.Size = new System.Drawing.Size(325, 449);
            this.suspectTable.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(671, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Список подозрительных лиц";
            // 
            // suspect_birth
            // 
            this.suspect_birth.HeaderText = "Дата рождения";
            this.suspect_birth.MinimumWidth = 6;
            this.suspect_birth.Name = "suspect_birth";
            // 
            // suspect_name
            // 
            this.suspect_name.HeaderText = "ФИО";
            this.suspect_name.MinimumWidth = 6;
            this.suspect_name.Name = "suspect_name";
            // 
            // suspect_city
            // 
            this.suspect_city.HeaderText = "Город";
            this.suspect_city.MinimumWidth = 6;
            this.suspect_city.Name = "suspect_city";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Total);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tabuCity);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(12, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(974, 43);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Запрещенный город";
            // 
            // tabuCity
            // 
            this.tabuCity.Location = new System.Drawing.Point(153, 10);
            this.tabuCity.Name = "tabuCity";
            this.tabuCity.Size = new System.Drawing.Size(327, 22);
            this.tabuCity.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(536, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Заработок: ";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(626, 12);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(14, 16);
            this.Total.TabIndex = 3;
            this.Total.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.suspectTable);
            this.Controls.Add(this.deniedTable);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.acceptedTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Papers, please!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deniedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspectTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BirthDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox gMname;
        private System.Windows.Forms.TextBox gFname;
        private System.Windows.Forms.TextBox gLname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox gAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.DataGridView acceptedTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView deniedTable;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn accepted_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn accepted_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn accepted_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn denied_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn denied_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn denied_city;
        private System.Windows.Forms.DataGridView suspectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspect_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspect_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspect_city;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tabuCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label16;
    }
}

