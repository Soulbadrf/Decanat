using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decanat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void newDocument_Click(object sender, EventArgs e)
        {
            string msg = "Все не сохраненные данные будут утеряны! Продолжить?";
            string caption = "Создание нового файла";
            var result = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Если нажать да в появившимся окне, то все данные сотрутся
            if (result.Equals(DialogResult.Yes))
            {
                dataGridViewStudents.Rows.Clear();
                dataGridViewValues.Rows.Clear();

                if (dataGridViewValues.Visible.Equals(true))
                {
                    swapGrids();
                }
            }            
        }

        private void newLine_Click(object sender, EventArgs e)
        {
            //Если показывается 1 таблица, то добавляется запись в неё иначе во вторую таблицу
            if (dataGridViewStudents.Visible.Equals(true))
            {
                //Кнопка переключения между таблицами
                DataGridViewButtonColumn button = buttonCreate();

                int i = dataGridViewStudents.Rows.Count;

                //Если в документе нет строк, то айди строки равно 0 иначе равно на 1 больше предыдущего
                if (i == 0)
                {
                    dataGridViewStudents.Rows.Add(0, "", "", "", "", null, button.HeaderText);
                } else
                {
                    i = Int32.Parse(dataGridViewStudents.Rows[i-1].Cells[0].Value.ToString());
                    dataGridViewStudents.Rows.Add(++i, "", "", "", "", null, button.HeaderText);
                }                
            } else
            {
                dataGridViewValues.Rows.Add(labelId.Text,null, null, null, null);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            //Если произошло нажатие на кнопку для смены таблиц, то происходит заполнение новой таблицы для ученика и отображение таблицы
            if (e.ColumnIndex == 6)
            {
                string cell;
                try
                {
                    cell = dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    swapGrids();
                    return;
                }
                labelId.Text = cell;
                //Показываем лишь поля для выбранного студента
                for (int i = 0; i < dataGridViewValues.RowCount; i++)
                {
                    if (dataGridViewValues.Rows[i].Cells[0].Value.ToString().Equals(labelId.Text))
                    {
                        dataGridViewValues.Rows[i].Visible = true;
                    }
                }

                swapGrids();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            swapGrids();
        }

        private void swapGrids()
        {
            //Меняем местами таблицы
            if (dataGridViewStudents.Visible.Equals(true))
            {
                dataGridViewValues.Visible = true;
                dataGridViewStudents.Visible = false;

                backButton.Enabled = true;

            } else {

                dataGridViewStudents.Visible = true;
                dataGridViewValues.Visible = false;
                backButton.Enabled = false;

                hideRows();
                
                labelId.Text = "";
            }
            
        }

        public void hideRows()
        {
            //Скрываем все строки в таблице с оценками
            for (int i = 0; i < dataGridViewValues.RowCount; i++)
            {
                if (dataGridViewValues.Rows[i].Visible.Equals(true))
                {
                    dataGridViewValues.Rows[i].Visible = false;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Stream stream;
            //Построковое чтение таблицы и запись в файл с помощь потока и saveFileDialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {

                    TableLoader tableLoader = new TableLoader(this, stream);
                    tableLoader.saveTable();
                    
                }
                else
                {
                    MessageBox.Show("Error while saving File");
                }
            }
        }

        public DataGridViewButtonColumn buttonCreate()
        {
            //Создание кнопки для таблицы
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Сессии";
            button.Name = "sessionForm";            

            return button;
        }
        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //Загрузка файла работает также, как и сохранение но в обратном направлении
            Stream stream;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    TableLoader tableLoader = new TableLoader(this, stream);
                    tableLoader.loadTable();
                } 
                else
                {
                    MessageBox.Show("Error while loading File");
                }   
            }
        }

        private void debtors_Click(object sender, EventArgs e)
        {
            //Словарь хранит в себе данные о id студентов и кол-ве их долгов чтобы потом высчитать больше ли долгов чем 2 или нет
            Dictionary<int, int> students = new Dictionary<int, int>();
            int studentId;
            for (int i = 0; i < dataGridViewValues.RowCount; i++)
            {
                if (dataGridViewValues.Rows[i].Cells[4].Value.Equals(value.Items[0]) && dataGridViewValues.Rows[i].Cells[2].Value.Equals(session.Items[0]) && dataGridViewValues.Rows[i].Cells[3].Value.Equals(year.Items[3]))
                {
                    studentId = Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString());
                    if (!students.ContainsKey(studentId))
                    {
                        students.Add(studentId, 1);
                    } else
                    {
                        students[studentId] = students[studentId] + 1;
                    }
                }                
            }

            string msg = "";
            string caption = "Cтуденты имеющие больше 2 хвостов в летней сессии 2021";

            //Заполняем сообщение фамилиями студентов
            foreach (var item in students.Keys)
            {
                if (students[item] > 2)
                {
                    msg += dataGridViewStudents.Rows[item].Cells[1].Value.ToString();
                    msg += "\n";
                }
            }

            if (msg == "")
            {
                msg = "Такие студенты отсутсвуют";
            }

            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonUpperStep_Click(object sender, EventArgs e)
        {
            BestStudentsTable bst = new BestStudentsTable();
            DataGridView dgv = new DataGridView();
            dgv.ColumnCount = 4;
            Dictionary<int, int> students = new Dictionary<int, int>();
            int studentId;
            //Проверка всех оценок, заполнения словаря студентами.
            for (int i = 0; i < dataGridViewValues.RowCount; i++)
            {
                studentId = Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString());
                if (!students.ContainsKey(studentId))
                {
                    students.Add(studentId, 1);
                }
                // Если у студента есть какая то оценка кроме отлично или зачёт то он уходит из списка для повышенной стипендии
                if (!(dataGridViewValues.Rows[i].Cells[4].Value.Equals(value.Items[3]) || dataGridViewValues.Rows[i].Cells[4].Value.Equals(value.Items[4])))
                {
                    students[studentId] = 0;
                }
            }

            foreach (var item in students.Keys)
            {
                //Если студент имеет право на повышенную стипендию, то его фио и зачетка добавляются в таблицу
                if (students[item] == 1)
                {
                    DataGridViewRow row = dataGridViewStudents.Rows[item];                    
                    dgv.Rows.Add(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                                  
                }                
            }
            
            bst.gridFiller(dgv);

            bst.Show();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            GraphPainter gp = new GraphPainter();
            gp.graphPrinter(dataGridViewStudents, dataGridViewValues);
            gp.Show();
        }
        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            GraphPainter gp = new GraphPainter();
            gp.informatic(session, year, dataGridViewValues);
            gp.Show();
        }

        private void buttonDiagrams_Click(object sender, EventArgs e)
        {
            SpecializationDiagrams sd = new SpecializationDiagrams();
            string[] allSpecializations = new string[specialization.Items.Count];
            int[,] specCounter = new int[4, allSpecializations.Length];
            int[] allStudents = new int[dataGridViewStudents.RowCount];
            Array.Clear(specCounter, 0, specCounter.Length);
            Array.Clear(allStudents, 0, allStudents.Length);

            //в allStudents находится информация о курсе студента, в зависимости от его года его самого старого экзамена
            for (int i = 0; i < dataGridViewValues.RowCount; i++)
            {
                if (allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] == 0)
                {
                    allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] = 1;
                }
                
                switch (dataGridViewValues.Rows[i].Cells[3].Value.ToString())
                {
                    
                    case "2020":
                        if (allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] < 2)
                        {
                            allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] = 2;
                        }
                        break;
                    case "2019":
                        if (allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] < 3)
                        {
                            allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] = 3;
                        }
                        break;
                    case "2018":
                        if (allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] < 4)
                        {
                            allStudents[Int32.Parse(dataGridViewValues.Rows[i].Cells[0].Value.ToString())] = 4;
                        }
                        break;
                    default:
                        break;
                }
            }

            //Список всех специальностей
            for (int i = 0; i < specialization.Items.Count; i++)
            {
                allSpecializations[i] = specialization.Items[i].ToString();
            }

            //specCounter двухмерный массив содержащий информациб о кол-во студентов на каждом курсе дял кажой специальности
            for (int j = 0; j < allStudents.Length; j++)
            {
                specCounter[allStudents[j], specialization.Items.IndexOf(dataGridViewStudents.Rows[j].Cells[5].Value.ToString())]++;
            }

            sd.diagrammSetter(allSpecializations, specCounter, allStudents);
            sd.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                
                for (int i = 0; i < dataGridViewValues.Rows.Count; i++)
                {
                    if (dataGridViewValues.Rows[i].Cells[0].Value.ToString().Equals(dataGridViewStudents.SelectedRows[0].Cells[0]))
                    {
                        dataGridViewValues.Rows.RemoveAt(i);
                    }
                }
                dataGridViewStudents.Rows.Remove(dataGridViewStudents.SelectedRows[0]);
            } 
            else
            {
                MessageBox.Show("Не выбраны строки для удаления");
            }
        }

        public DataGridViewComboBoxColumn getSpecialicaztion()
        {
            return specialization;
        }

        public DataGridViewComboBoxColumn getSession()
        {
            return session;
        }

        public DataGridViewComboBoxColumn getValue()
        {
            return value;
        }

        public DataGridViewComboBoxColumn getYear()
        {
            return year;
        }

        public DataGridViewComboBoxColumn getSubject()
        {
            return subject;
        }

        public DataGridView getStudentsTable()
        {
            return dataGridViewStudents;
        }

        public DataGridView getValuesTable()
        {
            return dataGridViewValues;
        }
    }
}
