using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decanat
{
    class TableLoader
    {
        StreamWriter streamWriter;
        StreamReader streamReader;
        TableFiller tableFiller;
        MainForm mainForm;
        Stream stream;

        public TableLoader(MainForm mainForm, Stream stream)
        {
            tableFiller = new TableFiller(mainForm);
            this.mainForm = mainForm;
            this.stream = stream;
        }
        public void loadTable()
        {
            streamReader = new StreamReader(stream);

            try
            {
                tableFiller.tablesFiller(streamReader);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
                mainForm.hideRows();
            }
        }

        public void saveTable()
        {
            streamWriter = new StreamWriter(stream);

            try
            {
                tableFiller.tableSaveFileFiller(streamWriter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
