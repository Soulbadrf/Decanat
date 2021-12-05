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
    public partial class StudentGraph : Form
    {
        public StudentGraph()
        {
            InitializeComponent();
        }

        public void graphSetter(int[] data, int[] counters, string student)
        {
            chart1.Series[0].Name = student;
            for (int i = 0; i < data.Length; i++)
            {
                if (counters[i] != 0)
                {
                    chart1.Series[0].Points.AddXY(session(i), data[i] / counters[i]);
                }
            }
        }

        private string session(int i)
        {
            switch (i)
            {
                case 0:
                    return "Зимняя 2018";
                case 1:
                    return "Летняя 2018";
                case 2:
                    return "Зимняя 2019";
                case 3:
                    return "Летняя 2019";
                case 4:
                    return "Зимняя 2020";
                case 5:
                    return "Летняя 2020";
                case 6:
                    return "Зимняя 2021";
                case 7:
                    return "Летняя 2021";
                default:
                    return "";
            }
        }
    }
}
