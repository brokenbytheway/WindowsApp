﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;
using DataGridViewAutoFilter;


namespace WindowsApp
{
    public partial class Mobility : Form
    {
        public Mobility()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportFromExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                textBox3.Text = filepath;
                LoadDataFromExcelToDataGridView(filepath, ".xlsx", "yes");
            }
        }
        public void LoadDataFromExcelToDataGridView(string fpath, string ext, string hdr)
        {
            string con = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = String.Format(con, fpath, hdr);
            OleDbConnection excelcon = new OleDbConnection(con);
            excelcon.Open();
            DataTable exceldata = excelcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string exsheetname = exceldata.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand excelcmd = new OleDbCommand("Select * from [" + exsheetname + "]", excelcon);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(excelcmd);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            excelcon.Close();
            DataView dataView = dataTable.DefaultView;
            dataView.Sort = "Был ли на мобильности ранее DESC";
            dataTable = dataView.ToTable();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                object[] rowData = new object[row.ItemArray.Length + 1];
                rowData[0] = "false";
                for (int j = 0; j < row.ItemArray.Length; j++)
                {
                    rowData[j + 1] = row.ItemArray[j];
                }
                mobTable.Rows.Add(rowData);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = mobTable2.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = mobTable2.Rows[i];
                if (Convert.ToBoolean(row.Cells["toRemove"].Value))
                {
                    object[] rowData = new object[row.Cells.Count + 1];
                    rowData[0] = "false";
                    for (int j = 1; j < row.Cells.Count; j++)
                    {
                        rowData[j] = row.Cells[j].Value;
                    }
                    mobTable.Rows.Add(rowData);
                    mobTable2.Rows.RemoveAt(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = mobTable.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = mobTable.Rows[i];
                if (Convert.ToBoolean(row.Cells["toAdd"].Value))
                {
                    object[] rowData = new object[row.Cells.Count + 1];
                    rowData[0] = "false";
                    for (int j = 1; j < row.Cells.Count; j++)
                    {
                        rowData[j] = row.Cells[j].Value;
                    }
                    mobTable2.Rows.Add(rowData);
                    mobTable.Rows.RemoveAt(i);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mobility_Load(object sender, EventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            exApp.Columns.ColumnWidth = 15;

            // Заголовки столбцов
            string[] headers = { "Курс", "Направление", "Фамилия", "Имя", "Отчество", "Почта", "Был ли на мобильности ранее", "Направление мобильности", "Кампус", "Срок", "Рейтинг"};
            for (int j = 0; j < headers.Length; j++)
            {
                wsh.Cells[1, j + 1] = headers[j];
            }
            int row = 2; // Начинаем с следующей строки после заголовка

            // Экспортируем данные из DataGridView в Excel
            foreach (DataGridViewRow dgvRow in mobTable2.Rows)
            {
                for (int col = 1; col < mobTable2.Columns.Count; col++)
                {
                    wsh.Cells[row, col] = dgvRow.Cells[col].Value;
                }
                row++;
            }
            exApp.Visible = true;
        }
    }
}
