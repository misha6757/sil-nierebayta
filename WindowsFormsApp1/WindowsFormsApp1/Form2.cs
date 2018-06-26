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
               OleDbDataAdapter("SELECT Boat.Model FROM Boat WHERE Mast IN (TRUE);", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT Boat.Model FROM Boat WHERE Mast IN (TRUE);", conn);
            zapros4.SelectCommand = command;
            DataTable DTzap4 = new DataTable();
            zapros4.Fill(DTzap4);
            BindingSource BSzap4 = new BindingSource();
            BSzap4.DataSource = DTzap4;
            dataGridView2.DataSource = BSzap4;
            //dataGridView2.Columns[0].HeaderCell.Value = "Максимальная стоимость";
            conn.Close();
            MessageBox.Show("Лодки с матчтой ");
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void деталиЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void партнерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void аксToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void аксессуарыЛодкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void документToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void продавецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
    }
}
