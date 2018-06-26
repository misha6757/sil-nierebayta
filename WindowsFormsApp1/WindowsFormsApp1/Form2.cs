using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bsDataSet1.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.bsDataSet1.Boat);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
          
               
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                this.boatTableAdapter.Update(this.bsDataSet1.Boat);
            }
            catch
            {
                MessageBox.Show("Нештяк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
             Data Source=C:\Users\studkab43\Desktop\Бондарев Михаил 3\WindowsFormsApp1\WindowsFormsApp1\bs.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros4 = new
               OleDbDataAdapter("SELECT Boat.Mast FROM Boat WHERE oplata IN ('да');", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT zakaz.idzak, zakaz.idcust FROM zakaz WHERE oplata IN ('да');", conn);
            zapros4.SelectCommand = command;
            DataTable DTzap4 = new DataTable();
            zapros4.Fill(DTzap4);
            BindingSource BSzap4 = new BindingSource();
            BSzap4.DataSource = DTzap4;
            dataGridView2.DataSource = BSzap4;
            //dataGridView2.Columns[0].HeaderCell.Value = "Максимальная стоимость";
            conn.Close();
            MessageBox.Show("Оплаченные заказ");
        }
    }
}
