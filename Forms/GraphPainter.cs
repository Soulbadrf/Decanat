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
    public partial class GraphPainter : Form
    {
        private DataGridView dataGridViewStudents;
        private DataGridView dataGridViewValues;
        public GraphPainter()
        {
            InitializeComponent();
        }

        public void graphPrinter(DataGridView dataGridViewStudents, DataGridView dataGridViewValues)
        {
            this.dataGridViewStudents = dataGridViewStudents;
            this.dataGridViewValues = dataGridViewValues;
            menuLabel.Text = "Введите номер зачетки";
            textBoxStudent.Visible = true;
        }

        public void informatic(DataGridViewComboBoxColumn session, DataGridViewComboBoxColumn year, DataGridView dataGridViewValues)
        {
            this.dataGridViewValues = dataGridViewValues;

            menuLabel.Text = "Выберите год и сезон сессии";
            comboBoxSession.Visible = true;
            comboBoxYear.Visible = true;

            for (int i = 0; i < year.Items.Count; i++)
            {
                comboBoxYear.Items.Add(year.Items[i]);
            }

            for (int i = 0; i < session.Items.Count; i++)
            {
                comboBoxSession.Items.Add(session.Items[i]);
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            //В зависимости от того, какая форма открыта для построения графика или круговой диаграммы будут вызывать разные формы
            if (textBoxStudent.Visible.Equals(true))
            {
                for (int i = 0; i < dataGridViewStudents.Rows.Count; i++)
                {
                    string student;
                    //Если находися зачетка студента для которого нужен график
                    if (dataGridViewStudents.Rows[i].Cells[4].Value.ToString().Equals(textBoxStudent.Text))
                    {
                        StudentGraph sg = new StudentGraph();
                        int[] data = new int[8];
                        int[] counters = new int[8];
                        Array.Clear(data, 0, data.Length);
                        Array.Clear(counters, 0, counters.Length);
                        student = dataGridViewStudents.Rows[i].Cells[1].Value.ToString();

                        //Перебираем все сессии студента для расчета среднего балла
                        for (int j = 0; j < dataGridViewValues.Rows.Count; j++)
                        {
                            if (dataGridViewValues.Rows[j].Cells[0].Value.ToString().Equals(i.ToString()))
                            {
                                switch (dataGridViewValues.Rows[j].Cells[3].Value.ToString())
                                {
                                    case "2018":
                                        if (dataGridViewValues.Rows[j].Cells[2].Value.ToString().Equals("Зимняя"))
                                        {
                                            data[0]+= getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[0]++;
                                            }
                                        } else
                                        {
                                            data[1] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[1]++;
                                            }
                                        }
                                            
                                        break;
                                    case "2019":
                                        if (dataGridViewValues.Rows[j].Cells[2].Value.ToString().Equals("Зимняя"))
                                        {
                                            data[2] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[2]++;
                                            }
                                        }
                                        else
                                        {
                                            data[3] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[3]++;
                                            }
                                        }
                                        break;
                                    case "2020":
                                        if (dataGridViewValues.Rows[j].Cells[2].Value.ToString().Equals("Зимняя"))
                                        {
                                            data[4] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[4]++;
                                            }
                                        }
                                        else
                                        {
                                            data[5] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[5]++;
                                            }
                                        }
                                        break;
                                    case "2021":
                                        if (dataGridViewValues.Rows[j].Cells[2].Value.ToString().Equals("Зимняя"))
                                        {
                                            data[6] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[6]++;
                                            }
                                        }
                                        else
                                        {
                                            data[7] += getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString());
                                            if (getValueOfSessuion(dataGridViewValues.Rows[j].Cells[4].Value.ToString()) != 0)
                                            {
                                                counters[7]++;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        sg.Show();
                        return;
                    }
                }

                MessageBox.Show("Не найдено студента с таким номером зачетки");
            } 
            else
            {
                if (comboBoxSession.Text == "" || comboBoxYear.Text == "")
                {
                    MessageBox.Show("Вы не выбрали сессию");
                    return;
                }

                InformaticDiagram id = new InformaticDiagram();
                int[] sessionValues = new int[3];
                sessionValues[0] = 0;
                sessionValues[1] = 0;
                sessionValues[2] = 0;

                //Поиск всех оценок по информатике за указанную сессию для нахождения данных для круговой диаграммы
                for (int i = 0; i < dataGridViewValues.Rows.Count; i++)
                {
                    if (dataGridViewValues.Rows[i].Cells[1].Value.ToString().Equals("Информатика") && dataGridViewValues.Rows[i].Cells[2].Value.ToString().Equals(comboBoxSession.Text) && dataGridViewValues.Rows[i].Cells[3].Value.ToString().Equals(comboBoxYear.Text))
                    {
                        switch (dataGridViewValues.Rows[i].Cells[4].Value.ToString())
                        {
                            case "Удовлитворительно":
                                sessionValues[0]++;
                                break;
                            case "Хорошо":
                                sessionValues[1]++;
                                break;
                            case "Отлично":
                                sessionValues[2]++;
                                break;
                        }
                    }
                }

                id.chartSetter(sessionValues, comboBoxSession.Text + " " + comboBoxYear.Text);
                id.Show();
            }
        }

        private int getValueOfSessuion(string value)
        {
            switch (value)
            {
                case "Удовлитворительно":
                    return 3;
                case "Хорошо":
                    return 4;
                case "Отлично":
                    return 5;
                default:
                    return 0;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
