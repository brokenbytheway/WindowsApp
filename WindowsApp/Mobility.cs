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
            string[] headers = { "Курс", "Направление", "Фамилия", "Имя", "Отчество", "Почта", "Рейтинг", "Был ли на мобильности ранее", "Направление мобильности", "Кампус", "Срок" };
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

        public class ColumnFilterClickedEventArg : EventArgs
        {
            public int ColumnIndex { get; private set; }
            public Rectangle ButtonRectangle { get; private set; }
            public ColumnFilterClickedEventArg(int colIndex, Rectangle btnRect)
            {
                this.ColumnIndex = colIndex;
                this.ButtonRectangle = btnRect;
            }
        }

        public class DataGridFilterHeader : DataGridViewColumnHeaderCell
        {
            // состояние кнопки
            ComboBoxState currentState = ComboBoxState.Normal;
            Point cellLocation;
            Rectangle buttonRect;

            public event EventHandler<ColumnFilterClickedEventArg> FilterButtonClicked;
            // расширим заголовок на 20 пикселей что бы вставить туда кнопку
            protected override void OnDataGridViewChanged()
            {
                try
                {
                    Padding dropDownPadding = new Padding(0, 0, 20, 0);
                    this.Style.Padding = Padding.Add(this.InheritedStyle.Padding, dropDownPadding);
                }
                catch { }
                base.OnDataGridViewChanged();
            }
            // рисуем кнопку
            protected override void Paint(Graphics graphics,
                                      Rectangle clipBounds,
                                      Rectangle cellBounds,
                                      int rowIndex,
                                      DataGridViewElementStates dataGridViewElementState,
                                      object value,
                                      object formattedValue,
                                      string errorText,
                                      DataGridViewCellStyle cellStyle,
                                      DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds,
                       cellBounds, rowIndex,
                       dataGridViewElementState, value,
                       formattedValue, errorText,
                       cellStyle, advancedBorderStyle, paintParts);

                int width = 20;
                buttonRect = new Rectangle(cellBounds.X + cellBounds.Width - width, cellBounds.Y, width, cellBounds.Height);
                cellLocation = cellBounds.Location;
                ComboBoxRenderer.DrawDropDownButton(graphics, buttonRect, currentState);
            }
            // анимация нажатия
            protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
            {
                if (this.IsMouseOverButton(e.Location))
                    currentState = ComboBoxState.Pressed;
                base.OnMouseDown(e);
            }
            protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
            {
                if (this.IsMouseOverButton(e.Location))
                {
                    currentState = ComboBoxState.Normal;
                    this.OnFilterButtonClicked();
                }
                base.OnMouseUp(e);
            }
            private bool IsMouseOverButton(Point e)
            {
                Point p = new Point(e.X + cellLocation.X, e.Y + cellLocation.Y);
                if (p.X >= buttonRect.X && p.X <= buttonRect.X + buttonRect.Width &&
                p.Y >= buttonRect.Y && p.Y <= buttonRect.Y + buttonRect.Height)
                {
                    return true;
                }
                return false;
            }
            // активируем событие
            protected virtual void OnFilterButtonClicked()
            {
                if (this.FilterButtonClicked != null)
                {
                    this.FilterButtonClicked(this, new ColumnFilterClickedEventArg(this.ColumnIndex, this.buttonRect));
                }
            }
        }

        class FilterStatus
        {
            // имя колонки
            public string columnName { get; set; }
            // значение ячейки
            public string valueString { get; set; }
            // состояние фильтра
            public bool check { get; set; }
        }


    }
}
