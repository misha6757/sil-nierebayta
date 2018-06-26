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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bsDataSet1.AccToBoats". При необходимости она может быть перемещена или удалена.
            this.accToBoatsTableAdapter.Fill(this.bsDataSet1.AccToBoats);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                this.accToBoatsTableAdapter.Update(this.bsDataSet1.AccToBoats);
            }
            catch
            {
                MessageBox.Show("Нештяк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
