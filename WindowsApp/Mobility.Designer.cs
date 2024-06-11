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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mobility));
            textBox2 = new TextBox();
            add = new Button();
            textBox3 = new TextBox();
            ExportFromExcel = new Button();
            ExportToExcel = new Button();
            textBox1 = new TextBox();
            help = new Button();
            helpProvider1 = new HelpProvider();
            delete = new Button();
            order = new Button();
            Filter = new Button();
            mobTable2 = new DataGridView();
            toAdd2 = new DataGridViewCheckBoxColumn();
            course2 = new DataGridViewTextBoxColumn();
            direction2 = new DataGridViewTextBoxColumn();
            surname2 = new DataGridViewTextBoxColumn();
            name2 = new DataGridViewTextBoxColumn();
            patronymic2 = new DataGridViewTextBoxColumn();
            email2 = new DataGridViewTextBoxColumn();
            wasOrNo2 = new DataGridViewTextBoxColumn();
            mobDirection2 = new DataGridViewTextBoxColumn();
            campus2 = new DataGridViewTextBoxColumn();
            time2 = new DataGridViewTextBoxColumn();
            rating2 = new DataGridViewTextBoxColumn();
            mobTable = new DataGridView();
            toAdd = new DataGridViewCheckBoxColumn();
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
            directions = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)mobTable2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mobTable).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.CornflowerBlue;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(0, 513);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1581, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "Одобренные заявки";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // add
            // 
            add.Cursor = Cursors.Hand;
            add.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            helpProvider1.SetHelpKeyword(add, "25");
            helpProvider1.SetHelpNavigator(add, HelpNavigator.TopicId);
            add.Image = Properties.Resources.стрелка_вниз;
            add.Location = new Point(686, 446);
            add.Name = "add";
            helpProvider1.SetShowHelp(add, true);
            add.Size = new Size(80, 60);
            add.TabIndex = 5;
            add.UseVisualStyleBackColor = true;
            add.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 8);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(371, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // ExportFromExcel
            // 
            ExportFromExcel.Cursor = Cursors.Hand;
            helpProvider1.SetHelpKeyword(ExportFromExcel, "24");
            helpProvider1.SetHelpNavigator(ExportFromExcel, HelpNavigator.TopicId);
            ExportFromExcel.Location = new Point(103, 7);
            ExportFromExcel.Name = "ExportFromExcel";
            helpProvider1.SetShowHelp(ExportFromExcel, true);
            ExportFromExcel.Size = new Size(148, 29);
            ExportFromExcel.TabIndex = 2;
            ExportFromExcel.Text = "Загрузить данные";
            ExportFromExcel.UseVisualStyleBackColor = true;
            ExportFromExcel.Click += ExportFromExcel_Click;
            // 
            // ExportToExcel
            // 
            ExportToExcel.Cursor = Cursors.Hand;
            helpProvider1.SetHelpKeyword(ExportToExcel, "46");
            helpProvider1.SetHelpNavigator(ExportToExcel, HelpNavigator.TopicId);
            ExportToExcel.Location = new Point(1396, 479);
            ExportToExcel.Margin = new Padding(3, 4, 3, 4);
            ExportToExcel.Name = "ExportToExcel";
            helpProvider1.SetShowHelp(ExportToExcel, true);
            ExportToExcel.Size = new Size(182, 31);
            ExportToExcel.TabIndex = 7;
            ExportToExcel.Text = "Экспорт в Excel-файл";
            ExportToExcel.UseVisualStyleBackColor = true;
            ExportToExcel.Click += export_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(0, 42);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1581, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Заявки на мобильность";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // help
            // 
            help.Cursor = Cursors.Help;
            help.Location = new Point(3, 7);
            help.Name = "help";
            help.Size = new Size(94, 29);
            help.TabIndex = 8;
            help.Text = "Помощь";
            help.UseVisualStyleBackColor = true;
            help.Click += help_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "Help.chm";
            // 
            // delete
            // 
            delete.Cursor = Cursors.Hand;
            delete.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            helpProvider1.SetHelpKeyword(delete, "45");
            helpProvider1.SetHelpNavigator(delete, HelpNavigator.TopicId);
            delete.Image = Properties.Resources.стрелка_вверх;
            delete.Location = new Point(803, 446);
            delete.Name = "delete";
            helpProvider1.SetShowHelp(delete, true);
            delete.Size = new Size(80, 60);
            delete.TabIndex = 11;
            delete.UseVisualStyleBackColor = true;
            delete.Click += button1_Click_1;
            // 
            // order
            // 
            order.Cursor = Cursors.Hand;
            order.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            helpProvider1.SetHelpKeyword(order, "25");
            helpProvider1.SetHelpNavigator(order, HelpNavigator.TopicId);
            order.Location = new Point(4, 442);
            order.Name = "order";
            helpProvider1.SetShowHelp(order, true);
            order.Size = new Size(146, 31);
            order.TabIndex = 15;
            order.Text = "Сортировать";
            order.UseVisualStyleBackColor = true;
            order.Click += button1_Click;
            // 
            // Filter
            // 
            Filter.Cursor = Cursors.Hand;
            Filter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            helpProvider1.SetHelpKeyword(Filter, "25");
            helpProvider1.SetHelpNavigator(Filter, HelpNavigator.TopicId);
            Filter.Location = new Point(369, 474);
            Filter.Name = "Filter";
            helpProvider1.SetShowHelp(Filter, true);
            Filter.Size = new Size(146, 31);
            Filter.TabIndex = 18;
            Filter.Text = "Фильтровать";
            Filter.UseVisualStyleBackColor = true;
            Filter.Click += Filter_Click;
            // 
            // mobTable2
            // 
            mobTable2.BackgroundColor = SystemColors.ActiveCaption;
            mobTable2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable2.Columns.AddRange(new DataGridViewColumn[] { toAdd2, course2, direction2, surname2, name2, patronymic2, email2, wasOrNo2, mobDirection2, campus2, time2, rating2 });
            mobTable2.Location = new Point(0, 539);
            mobTable2.Name = "mobTable2";
            mobTable2.RowHeadersWidth = 51;
            mobTable2.RowTemplate.Height = 29;
            mobTable2.Size = new Size(1582, 359);
            mobTable2.TabIndex = 12;
            mobTable2.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // toAdd2
            // 
            toAdd2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            toAdd2.HeaderText = "Выбрано";
            toAdd2.MinimumWidth = 24;
            toAdd2.Name = "toAdd2";
            toAdd2.Resizable = DataGridViewTriState.True;
            toAdd2.SortMode = DataGridViewColumnSortMode.Automatic;
            toAdd2.Width = 102;
            // 
            // course2
            // 
            course2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            course2.HeaderText = "Курс";
            course2.MinimumWidth = 24;
            course2.Name = "course2";
            course2.Width = 70;
            // 
            // direction2
            // 
            direction2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direction2.HeaderText = "Направление";
            direction2.MinimumWidth = 24;
            direction2.Name = "direction2";
            direction2.Width = 133;
            // 
            // surname2
            // 
            surname2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            surname2.HeaderText = "Фамилия";
            surname2.MinimumWidth = 24;
            surname2.Name = "surname2";
            surname2.Width = 102;
            // 
            // name2
            // 
            name2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name2.HeaderText = "Имя";
            name2.MinimumWidth = 24;
            name2.Name = "name2";
            name2.Width = 68;
            // 
            // patronymic2
            // 
            patronymic2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            patronymic2.HeaderText = "Отчество";
            patronymic2.MinimumWidth = 24;
            patronymic2.Name = "patronymic2";
            patronymic2.Width = 101;
            // 
            // email2
            // 
            email2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email2.HeaderText = "Почта";
            email2.MinimumWidth = 24;
            email2.Name = "email2";
            email2.Width = 80;
            // 
            // wasOrNo2
            // 
            wasOrNo2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wasOrNo2.HeaderText = "Был ли на мобильности ранее";
            wasOrNo2.MinimumWidth = 24;
            wasOrNo2.Name = "wasOrNo2";
            wasOrNo2.Width = 191;
            // 
            // mobDirection2
            // 
            mobDirection2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mobDirection2.HeaderText = "Направление мобильности";
            mobDirection2.MinimumWidth = 24;
            mobDirection2.Name = "mobDirection2";
            mobDirection2.Width = 210;
            // 
            // campus2
            // 
            campus2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            campus2.HeaderText = "Кампус";
            campus2.MinimumWidth = 24;
            campus2.Name = "campus2";
            campus2.Width = 89;
            // 
            // time2
            // 
            time2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            time2.HeaderText = "Срок";
            time2.MinimumWidth = 24;
            time2.Name = "time2";
            time2.Width = 72;
            // 
            // rating2
            // 
            rating2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rating2.HeaderText = "Рейтинг";
            rating2.MinimumWidth = 24;
            rating2.Name = "rating2";
            rating2.Width = 93;
            // 
            // mobTable
            // 
            mobTable.BackgroundColor = SystemColors.ActiveCaption;
            mobTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobTable.Columns.AddRange(new DataGridViewColumn[] { toAdd, course, direction, surname, name, patronymic, email, wasOrNo, mobDirection, campus, time, rating });
            mobTable.Location = new Point(0, 68);
            mobTable.Name = "mobTable";
            mobTable.RowHeadersWidth = 51;
            mobTable.RowTemplate.Height = 29;
            mobTable.Size = new Size(1582, 369);
            mobTable.TabIndex = 14;
            mobTable.CellContentClick += mobTable_CellContentClick;
            // 
            // toAdd
            // 
            toAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            toAdd.HeaderText = "Выбрано";
            toAdd.MinimumWidth = 24;
            toAdd.Name = "toAdd";
            toAdd.Resizable = DataGridViewTriState.True;
            toAdd.SortMode = DataGridViewColumnSortMode.Automatic;
            toAdd.Width = 102;
            // 
            // course
            // 
            course.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            course.HeaderText = "Курс";
            course.MinimumWidth = 24;
            course.Name = "course";
            course.Width = 70;
            // 
            // direction
            // 
            direction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direction.HeaderText = "Направление";
            direction.MinimumWidth = 24;
            direction.Name = "direction";
            direction.Width = 133;
            // 
            // surname
            // 
            surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            surname.HeaderText = "Фамилия";
            surname.MinimumWidth = 24;
            surname.Name = "surname";
            surname.Width = 102;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.HeaderText = "Имя";
            name.MinimumWidth = 24;
            name.Name = "name";
            name.Width = 68;
            // 
            // patronymic
            // 
            patronymic.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            patronymic.HeaderText = "Отчество";
            patronymic.MinimumWidth = 24;
            patronymic.Name = "patronymic";
            patronymic.Width = 101;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email.HeaderText = "Почта";
            email.MinimumWidth = 24;
            email.Name = "email";
            email.Width = 80;
            // 
            // wasOrNo
            // 
            wasOrNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wasOrNo.HeaderText = "Был ли на мобильности ранее";
            wasOrNo.MinimumWidth = 24;
            wasOrNo.Name = "wasOrNo";
            wasOrNo.Width = 191;
            // 
            // mobDirection
            // 
            mobDirection.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mobDirection.HeaderText = "Направление мобильности";
            mobDirection.MinimumWidth = 24;
            mobDirection.Name = "mobDirection";
            mobDirection.Width = 210;
            // 
            // campus
            // 
            campus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            campus.HeaderText = "Кампус";
            campus.MinimumWidth = 24;
            campus.Name = "campus";
            campus.Width = 89;
            // 
            // time
            // 
            time.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            time.HeaderText = "Срок";
            time.MinimumWidth = 24;
            time.Name = "time";
            time.Width = 72;
            // 
            // rating
            // 
            rating.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rating.HeaderText = "Рейтинг";
            rating.MinimumWidth = 24;
            rating.Name = "rating";
            rating.Width = 93;
            // 
            // directions
            // 
            directions.FormattingEnabled = true;
            directions.Items.AddRange(new object[] { "Программная инженерия", "Бизнес-информатика", "Экономика", "Менеджмент", "История", "Юриспруденция", "Дизайн", "Лингвистика", "Все направления" });
            directions.Location = new Point(257, 448);
            directions.Name = "directions";
            directions.Size = new Size(371, 28);
            directions.TabIndex = 19;
            directions.SelectedIndexChanged += Directions_SelectedIndexChanged;
            // 
            // Mobility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(215, 245, 255);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1582, 923);
            Controls.Add(directions);
            Controls.Add(Filter);
            Controls.Add(order);
            Controls.Add(mobTable);
            Controls.Add(mobTable2);
            Controls.Add(delete);
            Controls.Add(help);
            Controls.Add(textBox1);
            Controls.Add(ExportToExcel);
            Controls.Add(add);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(ExportFromExcel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            helpProvider1.SetHelpKeyword(this, "221");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.TopicId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mobility";
            helpProvider1.SetShowHelp(this, true);
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
        private TextBox textBox2;
        private Button add;
        private Button ExportToExcel;
        private TextBox textBox1;
        private Button help;
        private HelpProvider helpProvider1;
        private Button delete;
        private DataGridView mobTable2;
        private DataGridViewCheckBoxColumn toAdd2;
        private DataGridViewTextBoxColumn course2;
        private DataGridViewTextBoxColumn direction2;
        private DataGridViewTextBoxColumn surname2;
        private DataGridViewTextBoxColumn name2;
        private DataGridViewTextBoxColumn patronymic2;
        private DataGridViewTextBoxColumn email2;
        private DataGridViewTextBoxColumn wasOrNo2;
        private DataGridViewTextBoxColumn mobDirection2;
        private DataGridViewTextBoxColumn campus2;
        private DataGridViewTextBoxColumn time2;
        private DataGridViewTextBoxColumn rating2;
        private DataGridView mobTable;
        private DataGridViewCheckBoxColumn toAdd;
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
        private Button order;
        private Button Filter;
        private ComboBox directions;
    }
}