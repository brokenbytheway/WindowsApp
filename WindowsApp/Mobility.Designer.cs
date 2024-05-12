namespace WindowsApp
{
    partial class Mobility
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
            textBox2 = new TextBox();
            toRight = new Button();
            toLeft = new Button();
            mobTable2 = new DataGridView();
            toRemove = new DataGridViewCheckBoxColumn();
            course = new DataGridViewTextBoxColumn();
            direction = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            patronymic = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            wasOrNo = new DataGridViewTextBoxColumn();
            mobDirection = new DataGridViewTextBoxColumn();
            campus = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            rating = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            ExportFromExcel = new Button();
            ExportToExcel = new Button();
            mobTable = new DataGridView();
            toAdd = new DataGridViewCheckBoxColumn();
            course0 = new DataGridViewTextBoxColumn();
            direction0 = new DataGridViewTextBoxColumn();
            surname0 = new DataGridViewTextBoxColumn();
            name0 = new DataGridViewTextBoxColumn();
            patronymic0 = new DataGridViewTextBoxColumn();
            email0 = new DataGridViewTextBoxColumn();
            wasOrNo0 = new DataGridViewTextBoxColumn();
            mobDirection0 = new DataGridViewTextBoxColumn();
            campus0 = new DataGridViewTextBoxColumn();
            time0 = new DataGridViewTextBoxColumn();
            rating0 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)mobTable2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mobTable).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(0, 508);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1581, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "Одобренные заявки";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // toRight
            // 
            toRight.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            toRight.Location = new Point(754, 443);
            toRight.Name = "toRight";
            toRight.Size = new Size(59, 60);
            toRight.TabIndex = 5;
            toRight.Text = "↓";
            toRight.TextAlign = ContentAlignment.MiddleRight;
            toRight.UseVisualStyleBackColor = true;
            toRight.Click += button2_Click;
            // 
            // toLeft
            // 
            toLeft.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            toLeft.ImageAlign = ContentAlignment.MiddleRight;
            toLeft.Location = new Point(688, 443);
            toLeft.Name = "toLeft";
            toLeft.Size = new Size(59, 60);
            toLeft.TabIndex = 4;
            toLeft.Text = "↑";
            toLeft.TextAlign = ContentAlignment.MiddleRight;
            toLeft.UseVisualStyleBackColor = true;
            toLeft.Click += button1_Click;
            // 
            // mobTable2
            // 
            mobTable2.AllowUserToAddRows = false;
            mobTable2.AllowUserToDeleteRows = false;
            mobTable2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable2.Columns.AddRange(new DataGridViewColumn[] { toRemove, course, direction, surname, name, patronymic, email, wasOrNo, mobDirection, campus, time, rating });
            mobTable2.Location = new Point(0, 536);
            mobTable2.Name = "mobTable2";
            mobTable2.RowHeadersWidth = 51;
            mobTable2.RowTemplate.Height = 29;
            mobTable2.Size = new Size(1582, 349);
            mobTable2.TabIndex = 1;
            mobTable2.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // toRemove
            // 
            toRemove.HeaderText = "Выбрано";
            toRemove.MinimumWidth = 80;
            toRemove.Name = "toRemove";
            toRemove.Width = 80;
            // 
            // course
            // 
            course.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            course.HeaderText = "Курс";
            course.MinimumWidth = 58;
            course.Name = "course";
            course.Width = 70;
            // 
            // direction
            // 
            direction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direction.HeaderText = "Направление";
            direction.MinimumWidth = 106;
            direction.Name = "direction";
            direction.Width = 133;
            // 
            // surname
            // 
            surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            surname.HeaderText = "Фамилия";
            surname.MinimumWidth = 83;
            surname.Name = "surname";
            surname.Width = 102;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.HeaderText = "Имя";
            name.MinimumWidth = 56;
            name.Name = "name";
            name.Width = 68;
            // 
            // patronymic
            // 
            patronymic.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            patronymic.HeaderText = "Отчество";
            patronymic.MinimumWidth = 83;
            patronymic.Name = "patronymic";
            patronymic.Width = 101;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email.HeaderText = "Почта";
            email.MinimumWidth = 50;
            email.Name = "email";
            email.Width = 80;
            // 
            // wasOrNo
            // 
            wasOrNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wasOrNo.HeaderText = "Был ли на мобильности ранее";
            wasOrNo.MinimumWidth = 154;
            wasOrNo.Name = "wasOrNo";
            wasOrNo.Width = 191;
            // 
            // mobDirection
            // 
            mobDirection.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mobDirection.HeaderText = "Направление мобильности";
            mobDirection.MinimumWidth = 168;
            mobDirection.Name = "mobDirection";
            mobDirection.Width = 210;
            // 
            // campus
            // 
            campus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            campus.HeaderText = "Кампус";
            campus.MinimumWidth = 73;
            campus.Name = "campus";
            campus.Width = 89;
            // 
            // time
            // 
            time.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            time.HeaderText = "Срок";
            time.MinimumWidth = 50;
            time.Name = "time";
            time.Width = 72;
            // 
            // rating
            // 
            rating.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rating.HeaderText = "Рейтинг";
            rating.MinimumWidth = 76;
            rating.Name = "rating";
            rating.Width = 93;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 446);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(371, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // ExportFromExcel
            // 
            ExportFromExcel.Location = new Point(0, 443);
            ExportFromExcel.Name = "ExportFromExcel";
            ExportFromExcel.Size = new Size(134, 32);
            ExportFromExcel.TabIndex = 2;
            ExportFromExcel.Text = "Скачать данные";
            ExportFromExcel.UseVisualStyleBackColor = true;
            ExportFromExcel.Click += ExportFromExcel_Click;
            // 
            // ExportToExcel
            // 
            ExportToExcel.Location = new Point(1399, 472);
            ExportToExcel.Margin = new Padding(3, 4, 3, 4);
            ExportToExcel.Name = "ExportToExcel";
            ExportToExcel.Size = new Size(182, 31);
            ExportToExcel.TabIndex = 7;
            ExportToExcel.Text = "Экспорт в Excel-файл";
            ExportToExcel.UseVisualStyleBackColor = true;
            ExportToExcel.Click += export_Click;
            // 
            // mobTable
            // 
            mobTable.AllowUserToAddRows = false;
            mobTable.AllowUserToDeleteRows = false;
            mobTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable.Columns.AddRange(new DataGridViewColumn[] { toAdd, course0, direction0, surname0, name0, patronymic0, email0, wasOrNo0, mobDirection0, campus0, time0, rating0 });
            mobTable.Location = new Point(0, 59);
            mobTable.Name = "mobTable";
            mobTable.RowHeadersWidth = 51;
            mobTable.RowTemplate.Height = 29;
            mobTable.Size = new Size(1582, 379);
            mobTable.TabIndex = 1;
            mobTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toAdd
            // 
            toAdd.HeaderText = "Выбрано";
            toAdd.MinimumWidth = 6;
            toAdd.Name = "toAdd";
            toAdd.Width = 80;
            // 
            // course0
            // 
            course0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            course0.HeaderText = "Курс";
            course0.MinimumWidth = 60;
            course0.Name = "course0";
            course0.Width = 70;
            // 
            // direction0
            // 
            direction0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direction0.HeaderText = "Направление";
            direction0.MinimumWidth = 106;
            direction0.Name = "direction0";
            direction0.Width = 133;
            // 
            // surname0
            // 
            surname0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            surname0.HeaderText = "Фамилия";
            surname0.MinimumWidth = 83;
            surname0.Name = "surname0";
            surname0.Width = 102;
            // 
            // name0
            // 
            name0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name0.HeaderText = "Имя";
            name0.MinimumWidth = 56;
            name0.Name = "name0";
            name0.Width = 68;
            // 
            // patronymic0
            // 
            patronymic0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            patronymic0.HeaderText = "Отчество";
            patronymic0.MinimumWidth = 83;
            patronymic0.Name = "patronymic0";
            patronymic0.Width = 101;
            // 
            // email0
            // 
            email0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email0.HeaderText = "Почта";
            email0.MinimumWidth = 66;
            email0.Name = "email0";
            email0.Width = 80;
            // 
            // wasOrNo0
            // 
            wasOrNo0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wasOrNo0.HeaderText = "Был ли на мобильности ранее";
            wasOrNo0.MinimumWidth = 154;
            wasOrNo0.Name = "wasOrNo0";
            wasOrNo0.Width = 191;
            // 
            // mobDirection0
            // 
            mobDirection0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mobDirection0.HeaderText = "Направление мобильности";
            mobDirection0.MinimumWidth = 168;
            mobDirection0.Name = "mobDirection0";
            mobDirection0.Width = 210;
            // 
            // campus0
            // 
            campus0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            campus0.HeaderText = "Кампус";
            campus0.MinimumWidth = 73;
            campus0.Name = "campus0";
            campus0.Width = 89;
            // 
            // time0
            // 
            time0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            time0.HeaderText = "Срок";
            time0.MinimumWidth = 60;
            time0.Name = "time0";
            time0.Width = 72;
            // 
            // rating0
            // 
            rating0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rating0.HeaderText = "Рейтинг";
            rating0.MinimumWidth = 76;
            rating0.Name = "rating0";
            rating0.Width = 93;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 34);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1581, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Заявки на мобильность";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Помощь";
            button1.UseVisualStyleBackColor = true;
            // 
            // Mobility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(215, 245, 255);
            ClientSize = new Size(1582, 923);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(mobTable);
            Controls.Add(ExportToExcel);
            Controls.Add(toRight);
            Controls.Add(textBox3);
            Controls.Add(toLeft);
            Controls.Add(textBox2);
            Controls.Add(ExportFromExcel);
            Controls.Add(mobTable2);
            Name = "Mobility";
            Text = "Mobility";
            Load += Mobility_Load;
            ((System.ComponentModel.ISupportInitialize)mobTable2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mobTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExportFromExcel;
        private TextBox textBox3;
        private Button toLeft;
        private TextBox textBox2;
        private Button toRight;
        private DataGridView mobTable2;
        private Button ExportToExcel;
        private DataGridView mobTable;
        private TextBox textBox1;
        private DataGridViewCheckBoxColumn toRemove;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn direction;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn patronymic;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn wasOrNo;
        private DataGridViewTextBoxColumn mobDirection;
        private DataGridViewTextBoxColumn campus;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn rating;
        private DataGridViewCheckBoxColumn toAdd;
        private DataGridViewTextBoxColumn course0;
        private DataGridViewTextBoxColumn direction0;
        private DataGridViewTextBoxColumn surname0;
        private DataGridViewTextBoxColumn name0;
        private DataGridViewTextBoxColumn patronymic0;
        private DataGridViewTextBoxColumn email0;
        private DataGridViewTextBoxColumn wasOrNo0;
        private DataGridViewTextBoxColumn mobDirection0;
        private DataGridViewTextBoxColumn campus0;
        private DataGridViewTextBoxColumn time0;
        private DataGridViewTextBoxColumn rating0;
        private Button button1;
    }
}