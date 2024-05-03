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
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dataTable.Rows[i];
                mobTable.Rows.Add("false", row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
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
                    mobTable.Rows.Add("false", mobTable2.Rows[i].Cells[1].Value.ToString(), mobTable2.Rows[i].Cells[2].Value.ToString(), mobTable2.Rows[i].Cells[3].Value.ToString(), mobTable2.Rows[i].Cells[4].Value.ToString(), mobTable2.Rows[i].Cells[5].Value.ToString());
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
                    mobTable2.Rows.Add("false", mobTable.Rows[i].Cells[1].Value.ToString(), mobTable.Rows[i].Cells[2].Value.ToString(), mobTable.Rows[i].Cells[3].Value.ToString(), mobTable.Rows[i].Cells[4].Value.ToString(), mobTable.Rows[i].Cells[5].Value.ToString());
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
    }
}
