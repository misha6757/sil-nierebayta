using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bsDataSet1.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.bsDataSet1.SalesPerson);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                this.salesPersonTableAdapter.Update(this.bsDataSet1.SalesPerson);
            }
            catch
            {
                MessageBox.Show("Нештяк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
