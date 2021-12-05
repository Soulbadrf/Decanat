using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decanat
{
    class TableFiller
    {
        MainForm mainForm;

        public TableFiller(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void tablesFiller(StreamReader streamReader)
        {
            string[] info = streamReader.ReadToEnd().Split('\n');
            string[] str;
            int stringCounter;
            bool gridCheck = true;

            stringCounter = info.Count() - 1;

            mainForm.getStudentsTable().Rows.Clear();
            mainForm.getValuesTable().Rows.Clear();

            for (int i = 0; i < stringCounter; i++)
            {
                str = info[i].Split(' ');
                try
                {
                    //Заполняем 1 таблицу пока не увидим метку, после чего начинаем заполнять вторую
                    if (gridCheck)
                    {
                        if (str[0] == "gridDelimeter\r")
                        {
                            gridCheck = false;
                            continue;
                        }

                        mainForm.getStudentsTable().Rows.Add(str[0], str[1], str[2], str[3], str[4], mainForm.getSpecialicaztion().Items[mainForm.getSpecialicaztion().Items.IndexOf(str[5])], mainForm.buttonCreate().HeaderText);
                    }
                    else
                    {
                        mainForm.getValuesTable().Rows.Add(str[0], mainForm.getSubject().Items[mainForm.getSubject().Items.IndexOf(str[1])], mainForm.getSession().Items[mainForm.getSession().Items.IndexOf(str[2])], mainForm.getYear().Items[mainForm.getYear().Items.IndexOf(str[3])], mainForm.getValue().Items[mainForm.getValue().Items.IndexOf(str[4])]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " sas");
                }
            }
            streamReader.Close();
        }

        public void tableSaveFileFiller(StreamWriter streamWriter)
        {
            try
            {
                for (int i = 0; i < mainForm.getStudentsTable().RowCount; i++)
                {
                    streamWriter.Write(mainForm.getStudentsTable().Rows[i].Cells[0].Value + " ");
                    streamWriter.Write(mainForm.getStudentsTable().Rows[i].Cells[1].Value + " ");
                    streamWriter.Write(mainForm.getStudentsTable().Rows[i].Cells[2].Value + " ");
                    streamWriter.Write(mainForm.getStudentsTable().Rows[i].Cells[3].Value + " ");
                    streamWriter.Write(mainForm.getStudentsTable().Rows[i].Cells[4].Value + " ");
                    streamWriter.Write(mainForm.getStudentsTable().Rows[i].Cells[5].Value + " ");
                    streamWriter.WriteLine();
                }
                //Метка в файле что бы понять, где закончилась 1 таблица и началась другая
                streamWriter.WriteLine("gridDelimeter");
                for (int i = 0; i < mainForm.getValuesTable().RowCount; i++)
                {
                    streamWriter.Write(mainForm.getValuesTable().Rows[i].Cells[0].Value + " ");
                    streamWriter.Write(mainForm.getValuesTable().Rows[i].Cells[1].Value + " ");
                    streamWriter.Write(mainForm.getValuesTable().Rows[i].Cells[2].Value + " ");
                    streamWriter.Write(mainForm.getValuesTable().Rows[i].Cells[3].Value + " ");
                    streamWriter.Write(mainForm.getValuesTable().Rows[i].Cells[4].Value + " ");
                    streamWriter.WriteLine();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                streamWriter.Close();
            }
        }
    }
}
