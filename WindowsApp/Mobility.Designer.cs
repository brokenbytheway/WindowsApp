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
            rating = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            ExportFromExcel = new Button();
            mobTable = new DataGridView();
            toAdd = new DataGridViewCheckBoxColumn();
            textBox1 = new TextBox();
            course0 = new DataGridViewTextBoxColumn();
            direction0 = new DataGridViewTextBoxColumn();
            surname0 = new DataGridViewTextBoxColumn();
            name0 = new DataGridViewTextBoxColumn();
            rating0 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mobTable2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mobTable).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 2);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(490, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "Одобренные заявки";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // toRight
            // 
            toRight.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toRight.Location = new Point(550, 262);
            toRight.Margin = new Padding(3, 2, 3, 2);
            toRight.Name = "toRight";
            toRight.Size = new Size(52, 44);
            toRight.TabIndex = 5;
            toRight.Text = ">>";
            toRight.UseVisualStyleBackColor = true;
            toRight.Click += button2_Click;
            // 
            // toLeft
            // 
            toLeft.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toLeft.Location = new Point(495, 262);
            toLeft.Margin = new Padding(3, 2, 3, 2);
            toLeft.Name = "toLeft";
            toLeft.Size = new Size(52, 44);
            toLeft.TabIndex = 4;
            toLeft.Text = "<<";
            toLeft.UseVisualStyleBackColor = true;
            toLeft.Click += button1_Click;
            // 
            // mobTable2
            // 
            mobTable2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable2.Columns.AddRange(new DataGridViewColumn[] { toRemove, course, direction, surname, name, rating });
            mobTable2.Location = new Point(607, 20);
            mobTable2.Margin = new Padding(3, 2, 3, 2);
            mobTable2.Name = "mobTable2";
            mobTable2.RowHeadersWidth = 51;
            mobTable2.RowTemplate.Height = 29;
            mobTable2.Size = new Size(494, 552);
            mobTable2.TabIndex = 1;
            mobTable2.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // toRemove
            // 
            toRemove.HeaderText = "Выбрано";
            toRemove.MinimumWidth = 6;
            toRemove.Name = "toRemove";
            toRemove.Width = 80;
            // 
            // course
            // 
            course.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            course.HeaderText = "Курс";
            course.MinimumWidth = 50;
            course.Name = "course";
            course.ReadOnly = true;
            course.Width = 58;
            // 
            // direction
            // 
            direction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direction.HeaderText = "Направление";
            direction.MinimumWidth = 150;
            direction.Name = "direction";
            direction.ReadOnly = true;
            direction.Width = 150;
            // 
            // surname
            // 
            surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            surname.HeaderText = "Фамилия";
            surname.MinimumWidth = 150;
            surname.Name = "surname";
            surname.ReadOnly = true;
            surname.Width = 150;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.HeaderText = "Имя";
            name.MinimumWidth = 150;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 150;
            // 
            // rating
            // 
            rating.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rating.HeaderText = "Рейтинг";
            rating.MinimumWidth = 70;
            rating.Name = "rating";
            rating.ReadOnly = true;
            rating.Width = 76;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 646);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 23);
            textBox3.TabIndex = 3;
            // 
            // ExportFromExcel
            // 
            ExportFromExcel.Location = new Point(190, 599);
            ExportFromExcel.Margin = new Padding(3, 2, 3, 2);
            ExportFromExcel.Name = "ExportFromExcel";
            ExportFromExcel.Size = new Size(117, 24);
            ExportFromExcel.TabIndex = 2;
            ExportFromExcel.Text = "Скачать данные";
            ExportFromExcel.UseVisualStyleBackColor = true;
            ExportFromExcel.Click += ExportFromExcel_Click;
            // 
            // mobTable
            // 
            mobTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable.Columns.AddRange(new DataGridViewColumn[] { toAdd, course0, direction0, surname0, name0, rating0 });
            mobTable.Location = new Point(0, 20);
            mobTable.Margin = new Padding(3, 2, 3, 2);
            mobTable.Name = "mobTable";
            mobTable.RowHeadersWidth = 51;
            mobTable.RowTemplate.Height = 29;
            mobTable.Size = new Size(490, 552);
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
            // textBox1
            // 
            textBox1.Location = new Point(0, 2);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Заявки на мобильность";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // course0
            // 
            course0.HeaderText = "Курс";
            course0.Name = "course0";
            course0.ReadOnly = true;
            // 
            // direction0
            // 
            direction0.HeaderText = "Направление";
            direction0.Name = "direction0";
            direction0.ReadOnly = true;
            // 
            // surname0
            // 
            surname0.HeaderText = "Фамилия";
            surname0.Name = "surname0";
            surname0.ReadOnly = true;
            // 
            // name0
            // 
            name0.HeaderText = "Имя";
            name0.Name = "name0";
            name0.ReadOnly = true;
            // 
            // rating0
            // 
            rating0.HeaderText = "Рейтинг";
            rating0.Name = "rating0";
            rating0.ReadOnly = true;
            // 
            // Mobility
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 245, 255);
            ClientSize = new Size(1104, 685);
            Controls.Add(toRight);
            Controls.Add(textBox3);
            Controls.Add(toLeft);
            Controls.Add(textBox2);
            Controls.Add(ExportFromExcel);
            Controls.Add(mobTable2);
            Controls.Add(textBox1);
            Controls.Add(mobTable);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Mobility";
            Text = "Mobility";
            Load += Mobility_Load;
            ((System.ComponentModel.ISupportInitialize)mobTable2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mobTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView mobTable;
        private Button ExportFromExcel;
        private TextBox textBox3;
        private Button toLeft;
        private TextBox textBox2;
        private Button toRight;
        private DataGridView mobTable2;
        private DataGridViewCheckBoxColumn toAdd;
        private DataGridViewCheckBoxColumn toRemove;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn direction;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn rating;
        private DataGridViewTextBoxColumn course0;
        private DataGridViewTextBoxColumn direction0;
        private DataGridViewTextBoxColumn surname0;
        private DataGridViewTextBoxColumn name0;
        private DataGridViewTextBoxColumn rating0;
    }
}