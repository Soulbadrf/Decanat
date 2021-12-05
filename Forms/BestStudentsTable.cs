using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decanat
{
    public partial class BestStudentsTable : Form
    {
        public BestStudentsTable()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        public void gridFiller(DataGridView dataGrid)
        {
            dataGridView1.RowCount = dataGrid.RowCount -1;
            for (int i = 0; i < dataGrid.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = dataGrid.Rows[i].Cells[0].Value;
                dataGridView1.Rows[i].Cells[1].Value = dataGrid.Rows[i].Cells[1].Value;
                dataGridView1.Rows[i].Cells[2].Value = dataGrid.Rows[i].Cells[2].Value;
                dataGridView1.Rows[i].Cells[3].Value = dataGrid.Rows[i].Cells[3].Value;
            }
        }
    }
}
