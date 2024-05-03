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
            textBox3 = new TextBox();
            ExportFromExcel = new Button();
            mobTable = new DataGridView();
            toAdd = new DataGridViewCheckBoxColumn();
            textBox1 = new TextBox();
            toRemove = new DataGridViewCheckBoxColumn();
            course = new DataGridViewTextBoxColumn();
            direction = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            rating = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mobTable2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mobTable).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(694, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "Одобренные заявки";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // toRight
            // 
            toRight.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toRight.Location = new Point(628, 349);
            toRight.Name = "toRight";
            toRight.Size = new Size(60, 58);
            toRight.TabIndex = 5;
            toRight.Text = ">>";
            toRight.UseVisualStyleBackColor = true;
            toRight.Click += button2_Click;
            // 
            // toLeft
            // 
            toLeft.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toLeft.Location = new Point(566, 349);
            toLeft.Name = "toLeft";
            toLeft.Size = new Size(60, 58);
            toLeft.TabIndex = 4;
            toLeft.Text = "<<";
            toLeft.UseVisualStyleBackColor = true;
            toLeft.Click += button1_Click;
            // 
            // mobTable2
            // 
            mobTable2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable2.Columns.AddRange(new DataGridViewColumn[] { toRemove, course, direction, surname, name, rating });
            mobTable2.Location = new Point(694, 27);
            mobTable2.Name = "mobTable2";
            mobTable2.RowHeadersWidth = 51;
            mobTable2.RowTemplate.Height = 29;
            mobTable2.Size = new Size(564, 736);
            mobTable2.TabIndex = 1;
            mobTable2.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 862);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(371, 27);
            textBox3.TabIndex = 3;
            // 
            // ExportFromExcel
            // 
            ExportFromExcel.Location = new Point(217, 799);
            ExportFromExcel.Name = "ExportFromExcel";
            ExportFromExcel.Size = new Size(134, 32);
            ExportFromExcel.TabIndex = 2;
            ExportFromExcel.Text = "Скачать данные";
            ExportFromExcel.UseVisualStyleBackColor = true;
            ExportFromExcel.Click += ExportFromExcel_Click;
            // 
            // mobTable
            // 
            mobTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable.Columns.AddRange(new DataGridViewColumn[] { toAdd });
            mobTable.Location = new Point(0, 27);
            mobTable.Name = "mobTable";
            mobTable.RowHeadersWidth = 51;
            mobTable.RowTemplate.Height = 29;
            mobTable.Size = new Size(560, 736);
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
            textBox1.Location = new Point(0, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Заявки на мобильность";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
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
            course.Width = 70;
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
            rating.Width = 93;
            // 
            // Mobility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 245, 255);
            ClientSize = new Size(1262, 913);
            Controls.Add(toRight);
            Controls.Add(textBox3);
            Controls.Add(toLeft);
            Controls.Add(textBox2);
            Controls.Add(ExportFromExcel);
            Controls.Add(mobTable2);
            Controls.Add(textBox1);
            Controls.Add(mobTable);
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
    }
}