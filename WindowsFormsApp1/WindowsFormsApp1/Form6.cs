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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bsDataSet1.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.bsDataSet1.Customer);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                this.customerTableAdapter.Update(this.bsDataSet1.Customer);
            }
            catch
            {
                MessageBox.Show("Нештяк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
