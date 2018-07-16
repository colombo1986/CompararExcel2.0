using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace CompararExcel2._0
{
    class ExportarCargasNuevas
    {
        public void ExportarExcel(DataGridView gridview3)
        {

            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Agregar Al Seguro";
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
                    for (int i = 0; i < gridview3.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < gridview3.Columns.Count; j++)
                        {

                            if ((gridview3.Rows[i].Cells[j].Value == null) == false)
                            {
                                if (gridview3.Rows[i].Cells[j].Value.ToString().Equals(""))
                                {
                                    gridview3.Rows[i].Cells[j].Value = "K";
                                } //Linea de codigo añadida porque los RUT con Guion K los mostraba como
                                  // un espacio en blanco en DataGrid 
                                hoja_trabajo.Cells[i + 1, j + 1] = gridview3.Rows[i].Cells[j].Value.ToString();
                            }

                            if (!gridview3.Rows[i].Cells[10].Value.ToString().Equals(""))
                            {
                                //string pattern = "dd/MM/yyyy"; 
                                string FechaSinHora = gridview3.Rows[i].Cells[10].Value.ToString();
                                // DateTime FechaSinHora2 = DateTime.ParseExact(FechaSinHora , pattern , CultureInfo.InvariantCulture); 
                                string resultado = FechaSinHora.Substring(0, 10);
                                gridview3.Rows[i].Cells[10].Value = resultado;
                            }

                            if (!gridview3.Rows[i].Cells[11].Value.ToString().Equals(""))
                            {

                                string FechaSinHora = gridview3.Rows[i].Cells[11].Value.ToString();

                                string resultado = FechaSinHora.Substring(0, 10);
                                gridview3.Rows[i].Cells[11].Value = resultado;
                            }

                            if (!gridview3.Rows[i].Cells[12].Value.ToString().Equals(""))
                            {

                                string FechaSinHora = gridview3.Rows[i].Cells[12].Value.ToString();
                                string resultado = FechaSinHora.Substring(0, 10);
                                gridview3.Rows[i].Cells[12].Value = resultado;
                            }
                            Cursor.Current = Cursors.WaitCursor;
                        }

                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
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



