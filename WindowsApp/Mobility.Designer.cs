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
            panel1 = new Panel();
            ExportFromExcel = new Button();
            BotTable = new DataGridView();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotTable).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ExportFromExcel);
            panel1.Controls.Add(BotTable);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 913);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ExportFromExcel
            // 
            ExportFromExcel.Location = new Point(246, 769);
            ExportFromExcel.Name = "ExportFromExcel";
            ExportFromExcel.Size = new Size(134, 32);
            ExportFromExcel.TabIndex = 2;
            ExportFromExcel.Text = "Скачать данные";
            ExportFromExcel.UseVisualStyleBackColor = true;
            ExportFromExcel.Click += ExportFromExcel_Click;
            // 
            // BotTable
            // 
            BotTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BotTable.Dock = DockStyle.Top;
            BotTable.Location = new Point(0, 27);
            BotTable.Name = "BotTable";
            BotTable.RowHeadersWidth = 51;
            BotTable.RowTemplate.Height = 29;
            BotTable.Size = new Size(630, 736);
            BotTable.TabIndex = 1;
            BotTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(630, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Таблица";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(632, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 913);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(630, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "Не таблица";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Mobility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 245, 255);
            ClientSize = new Size(1262, 913);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Mobility";
            Text = "Mobility";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BotTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private DataGridView BotTable;
        private Button ExportFromExcel;
    }
}