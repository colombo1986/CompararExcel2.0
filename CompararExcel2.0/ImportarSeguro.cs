﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompararExcel2._0
{
    class ImportarSeguro
    {
        OleDbConnection cons;
        OleDbDataAdapter MyDataAdapters;
        DataTable dtseguro;

        public void importarExcelSeguro(DataGridView dgv, string nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile2S = new OpenFileDialog();
                openfile2S.Filter = "Excel files |*.xlsx";
                openfile2S.Title = "Seleccion el archivo del Seguro";

                if (openfile2S.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile2S.FileName.Equals("") == false)
                    {
                        ruta = openfile2S.FileName;

                    }
                    cons = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ; data source= " + ruta + ";Extended Properties='Excel 12.0 Xml;HDR =YES'");
                    MyDataAdapters = new OleDbDataAdapter("Select *from [" + nombreHoja + "$]", cons);
                    dtseguro = new DataTable();
                    MyDataAdapters.Fill(dtseguro);
                    dgv.DataSource = dtseguro;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Asegurese que el nombre de la hoja es BCI");
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
