using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompararExcel2._0
{
    class ExportarTitularesNuevos
    {
        public void TitularesNuevos(DataGridView dataTitulares2)
        {

            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "TitularesNuevos";

                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);


                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dataTitulares2.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataTitulares2.Columns.Count; j++)
                        {

                            if ((dataTitulares2.Rows[i].Cells[j].Value == null) == false)
                            {
                                if (dataTitulares2.Rows[i].Cells[1].Value.ToString().Equals(""))
                                {
                                    dataTitulares2.Rows[i].Cells[1].Value = "K";
                                } //Linea de codigo añadida porque los RUT con Guion K los mostraba como
                                  // un espacio en blanco en DataGrid 

                                if (!dataTitulares2.Rows[i].Cells[6].Value.ToString().Equals(""))
                                {

                                    string FechaSinHora = dataTitulares2.Rows[i].Cells[6].Value.ToString();
                                    string resultado = FechaSinHora.Substring(0, 10);
                                    dataTitulares2.Rows[i].Cells[6].Value = resultado;
                                }

                                if (!dataTitulares2.Rows[i].Cells[8].Value.ToString().Equals(""))
                                {

                                    string FechaSinHora = dataTitulares2.Rows[i].Cells[8].Value.ToString();
                                    string resultado = FechaSinHora.Substring(0, 10);
                                    dataTitulares2.Rows[i].Cells[8].Value = resultado;
                                }


                                hoja_trabajo.Cells[i + 1, j + 1] = dataTitulares2.Rows[i].Cells[j].Value.ToString();
                                Cursor.Current = Cursors.WaitCursor;
                            }
                        }

                    }

                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Archivo Exportado con exito");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }

    }
}
