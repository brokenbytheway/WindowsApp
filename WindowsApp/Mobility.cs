using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

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

        private void ExportFromExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                textBox3.Text = filepath;
                try
                {
                    LoadDataFromExcelToDataGridView(filepath, ".xlsx", "yes");
                }
                catch
                {
                    MessageBox.Show("В приложение может быть загружена только таблицы формата \".xlsx\".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                object[] rowData = new object[row.ItemArray.Length + 1];
                rowData[0] = "false";
                for (int j = 0; j < row.ItemArray.Length; j++)
                    rowData[j + 1] = row.ItemArray[j];
                mobTable.Rows.Add(rowData);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stack<object[]> reversed = new Stack<object[]>();
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
                    reversed.Push(rowData);
                    mobTable.Rows.RemoveAt(i);
                }
            }
            while (reversed.Count > 0)
                mobTable2.Rows.Add(reversed.Pop());
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
            string[] headers = { "Курс", "Направление", "Фамилия", "Имя", "Отчество", "Почта", "Был ли на мобильности ранее", "Направление мобильности", "Кампус", "Срок", "Рейтинг" };
            for (int j = 0; j < headers.Length; j++)
                wsh.Cells[1, j + 1] = headers[j];
            int row = 2; // Начинаем со следующей строки после заголовка

            // Экспортируем данные из DataGridView в Excel
            foreach (DataGridViewRow dgvRow in mobTable2.Rows)
            {
                for (int col = 1; col < mobTable2.Columns.Count; col++)
                    wsh.Cells[row, col] = dgvRow.Cells[col].Value;
                row++;
            }
            exApp.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = mobTable2.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = mobTable2.Rows[i];
                if (Convert.ToBoolean(row.Cells["toAdd2"].Value))
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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void mobTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object[]> toSort = new List<object[]>();
            for (int rowIndex = mobTable.Rows.Count - 2; rowIndex >= 0; rowIndex--)
            {
                object[] rowData = new object[12];
                rowData[0] = "false";
                for (int columnIndex = 0; columnIndex < 12; columnIndex++)
                    rowData[columnIndex] = mobTable.Rows[rowIndex].Cells[columnIndex].Value;
                toSort.Add(rowData);
                mobTable.Rows.RemoveAt(rowIndex);
            }
            try
            {
                var sorted = from row in toSort
                             orderby row[7] descending, row[11] descending
                             select row;
                foreach (object[] rowData in sorted)
                    mobTable.Rows.Add(rowData);
            }
            catch (InvalidOperationException ex)
            {
                foreach (object[] rowData in toSort)
                    mobTable.Rows.Add(rowData);
                MessageBox.Show("Ошибка сортировки: рейтинг должен быть заполнен в каждой строке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Дополнительная логика обработки ошибки, если необходимо
            }
        }

        List<object[]> apps = new List<object[]>();

        private void Filter_Click(object sender, EventArgs e)
        {
            string chosen = directions.Text;
            for (int rowIndex = mobTable.Rows.Count - 2; rowIndex >= 0; rowIndex--)
            {
                object[] rowData = new object[12];
                rowData[0] = "false";
                for (int columnIndex = 0; columnIndex < 12; columnIndex++)
                    rowData[columnIndex] = mobTable.Rows[rowIndex].Cells[columnIndex].Value;
                apps.Add(rowData);
                mobTable.Rows.RemoveAt(rowIndex);
            }
            apps = apps.Distinct(new ArrayEqualityComparer()).ToList();
            if (chosen == "Все направления" || chosen == "")
            {
                foreach (object[] rowData in apps)
                    mobTable.Rows.Add(rowData);
            }
            else
            {
                foreach (object[] rowData in apps)
                {
                    if (rowData[2].ToString() == chosen)
                        mobTable.Rows.Add(rowData);
                }
            }
        }

        public class ArrayEqualityComparer : IEqualityComparer<object[]>
        {
            public bool Equals(object[] x, object[] y)
            {
                if (x == null || y == null)
                    return x == y;
                if (x.Length != y.Length)
                    return false;
                return x.SequenceEqual(y);
            }
            public int GetHashCode(object[] obj)
            {
                unchecked
                {
                    int hash = 17;
                    foreach (object value in obj)
                        hash = hash * 23 + (value != null ? value.GetHashCode() : 0);
                    return hash;
                }
            }
        }

        private void Directions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}    