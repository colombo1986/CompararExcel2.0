using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompararExcel2._0
{
    class ImportarSigper
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void importarExcel(DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Sigper";

                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;

                    }


                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ; data source= " + ruta + ";Extended Properties='Excel 12.0 Xml;HDR =YES'");

                    //conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ruta + "Extended Properties='Excel 12.0 Xml;HDR =YES'");
                    MyDataAdapter = new OleDbDataAdapter("Select *from [" + nombreHoja + "$]", conn);
                    dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    dgv.DataSource = dt;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Asegurese que el nombre de la hoja es CARGAS");
                MessageBox.Show(ex.ToString());

            }
        }

    }
}
