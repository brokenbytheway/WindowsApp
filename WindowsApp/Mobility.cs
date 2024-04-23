using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


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
            BotTable.DataSource = dataTable;

        }
    }
}
