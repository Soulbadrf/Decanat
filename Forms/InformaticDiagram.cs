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
    public partial class InformaticDiagram : Form
    {
        public InformaticDiagram()
        {
            InitializeComponent();
        }

        public void chartSetter(int[] sessionValues, string session)
        {
            chart1.Series[0].Points.AddXY("Удовлитворительно", sessionValues[0]);
            chart1.Series[0].Points.AddXY("Хорошо", sessionValues[1]);
            chart1.Series[0].Points.AddXY("Отлично", sessionValues[2]);

            Text = "Информатика" + " " + session;            
        }
    }
}
