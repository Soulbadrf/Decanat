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
    public partial class SpecializationDiagrams : Form
    {
        public SpecializationDiagrams()
        {
            InitializeComponent();
        }

        public void diagrammSetter(string[] allSpecializations, int[,] specCounters, int[] allStudents)
        {

            for (int i = 0; i < allSpecializations.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (specCounters[j,i] > 0)
                    {
                        chart1.Series[j - 1].Points.AddXY(allSpecializations[i], specCounters[j, i]);
                    }
                }
            }
        }
    }
}
