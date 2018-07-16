using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompararExcel2._0
{
    public partial class ComparaCargas : Form
    {
        public ComparaCargas()
        {
            InitializeComponent();

            //Se añade una fila invisible al DataGrid 3 y 4 para que luego aparezca en el excel exportado
            //Se añade una fila invisible al DataGrid 3 y 4 para que luego aparezca en el excel exportado
            dataAgregarAseguro.Rows.Add("RUT_TITULAR", "DV_TITULAR", "NOMBRE_TITULAR", "AP_TITULAR", "AM_TITULAR", "NOMBRECARGA", "APELLIDOPATERNO", "APELLIDOMATERNO", "RUTCARGA", "DVCARGA", "FECHA INICIO", "FECHA TERMINO", "FECHA NACIMIENTO", "ESTADO", "TIPOSOCIO");
            dataAgregarAseguro.Rows[0].Visible = true;
            dataAgregarAseguro.Rows[0].Visible = false;
            dataSacarDelSeguro.Rows.Add("RUT_TITULAR", "DV_TITULAR", "NOMBRE_TITULAR", "AP_TITULAR", "AM_TITULAR", "NOMBRECARGA", "APELLIDOPATERNO", "APELLIDOMATERNO", "RUTCARGA", "DVCARGA", "FECHA INICIO", "FECHA TERMINO", "FECHA NACIMIENTO", "ESTADO", "TIPOSOCIO");
            dataSacarDelSeguro.Rows[0].Visible = true;
            dataSacarDelSeguro.Rows[0].Visible = false;

            btnSeguro.Visible = false;
            btnCompara.Visible = false;
            btnAgregarAseguro.Visible = false;
            btnSacarDelSeguro.Visible = false;
            btnSeguro.Visible = false;
            MaximizeBox = false;
        }

        private void ComparaCargas_Load(object sender, EventArgs e)
        {

        }

        private void btnSigper_Click(object sender, EventArgs e)
        {
            new ImportarSigper().importarExcel(dataCargas, "CARGAS");
            btnSeguro.Visible = true;
        }

        private void btnSeguro_Click(object sender, EventArgs e)
        {
            new ImportarSeguro().importarExcelSeguro(dataBCI, "BCI");
            btnCompara.Visible = true;
        }

        private void btnAgregarAseguro_Click(object sender, EventArgs e)
        {
            new ExportarCargasNuevas().ExportarExcel(dataAgregarAseguro);
        }

        private void btnSacarDelSeguro_Click(object sender, EventArgs e)
        {
            new ExportarSacarDelSeguro().ExportarExcelSacarDelSeguro(dataSacarDelSeguro);
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
           
            ArrayList ListaNoCoincidentes = new ArrayList();
            int nocoincidentes = 0;
            int sacarDelSeguro = 0;

            foreach (DataGridViewRow row2 in dataBCI.Rows)
            {
                //Se añaden todos los RUT de la columna Rut Asegurado [En el index 9]a un array list para comparar 
                //con el metodo contains 
                string RUTSEGURO = row2.Cells[9].Value.ToString();
                ListaNoCoincidentes.Add(RUTSEGURO);
            }


            foreach (DataGridViewRow row in dataCargas.Rows)
            {

                progressBar1.Increment(1); 

                string _RUTTITULAR = (row.Cells[0].Value.ToString());
                string _DVTITULAR = (row.Cells[1].Value.ToString());
                string _NOMBRETITULAR = (row.Cells[4].Value.ToString());
                string _AP_TITULAR = (row.Cells[2].Value.ToString());
                string _AM_TITULAR = (row.Cells[3].Value.ToString());
                string _TIPOSOCIO = (row.Cells[5].Value.ToString());
                string Nombres = (row.Cells[12].Value.ToString());
                string ApellidoPaterno = (row.Cells[10].Value.ToString());
                string ApellidoMaterno = (row.Cells[11].Value.ToString());
                string RUTCARGA = (row.Cells[8].Value.ToString());
                string _DVCARGA = (row.Cells[9].Value.ToString());
                string fechaInicio = (row.Cells[13].Value.ToString());
                string fechaTermino = (row.Cells[14].Value.ToString());
                string fechaNacimiento = (row.Cells[15].Value.ToString());
                string estado = (row.Cells[16].Value.ToString());

                if (fechaInicio.Equals("") || fechaInicio.Equals("/ /")
                    || fechaTermino.Equals("/ /") || fechaTermino.Equals("")
                    || estado.Equals("N") || estado.Equals("")
                    || estado.Equals("/ /") || fechaNacimiento.Equals("")
                    || fechaNacimiento.Equals("/ /"))
                {
                    // Filtrados , caen los que tienen campos en blanco


                }
                else //Hace todo el proceso 
                {

                    if (ListaNoCoincidentes.Contains(RUTCARGA))
                    {
                        //No hace nada por ahora 
                    }
                    else
                    {
                        //Se limpia la lista, se vuelve a llenar en la siguiente iteracion , pregunta si el segundo RUT
                        //De la planilla Sigper esta presente en el Array Lista de Coincidentes , que tiene la totalidad
                        //De los RUT de la planilla seguros
                        //dataGridView3.Rows.Add("RUT_TITULAR","DV_TITULAR","NOMBRE_TITULAR","AP_TITULAR","AM_TITULAR","NOMBRECARGA", "APELLIDOPATERNO", "APELLIDOMATERNO", "RUTCARGA", "DVCARGA", "FECHA NACIMIENTO", "FECHA INICIO", "FECHA TERMINO", "ESTADO");
                        // EstosNoEstaban.Add(nuevapersona);
                        nocoincidentes++;

                        dataAgregarAseguro.Rows.Add(_RUTTITULAR, _DVTITULAR, _NOMBRETITULAR, _AP_TITULAR, _AM_TITULAR, Nombres, ApellidoPaterno, ApellidoMaterno, RUTCARGA, _DVCARGA, fechaInicio, fechaTermino, fechaNacimiento, estado, _TIPOSOCIO);
                      
                    }
                }
            }

            ListaNoCoincidentes.Clear();
            //Otro proceso para no enredarme 
            // Todos los que esten en la planilla del seguro estan vigentes por defecto , ahora la planilla del seguro manda y hay que buscar
            //todos las personas que tiene y ver si estan contenidas en la planilla de sigper , si estan con una N sigifica que no 
            // estan vigentes en Sigper y se deben sacar 

            foreach (DataGridViewRow row2 in dataBCI.Rows)
            {
                //Se añaden todos los RUT de la columna Rut Asegurado [En el index 9]a un array list para comparar 
                //con el metodo contains , contra la planilla del sigper
                string RUTSEGURO = row2.Cells[9].Value.ToString();
                ListaNoCoincidentes.Add(RUTSEGURO);

            }

            foreach (DataGridViewRow row in dataCargas.Rows)
            {
                progressBar1.Increment(1);

                string _RUTTITULAR = (row.Cells[0].Value.ToString());
                string _DVTITULAR = (row.Cells[1].Value.ToString());
                string _NOMBRETITULAR = (row.Cells[4].Value.ToString());
                string _APTITULAR = (row.Cells[2].Value.ToString());
                string _AMTITULAR = (row.Cells[3].Value.ToString());
                string _TIPOSOCIO = (row.Cells[5].Value.ToString());

                string Nombres = (row.Cells[12].Value.ToString());
                string ApellidoPaterno = (row.Cells[10].Value.ToString());
                string ApellidoMaterno = (row.Cells[11].Value.ToString());
                string RUTCARGA = (row.Cells[8].Value.ToString());
                string _DVCARGA = (row.Cells[9].Value.ToString());
                string fechaInicio = (row.Cells[13].Value.ToString());
                string fechaTermino = (row.Cells[14].Value.ToString());
                string fechaNacimiento = (row.Cells[15].Value.ToString());
                string estado = (row.Cells[16].Value.ToString());

                if (ListaNoCoincidentes.Contains(RUTCARGA) && estado.Equals("N"))
                {
                    dataSacarDelSeguro.Rows.Add(_RUTTITULAR, _DVTITULAR, _NOMBRETITULAR, _APTITULAR, _AMTITULAR, Nombres, ApellidoPaterno, ApellidoMaterno, RUTCARGA, _DVCARGA, fechaInicio, fechaTermino, fechaNacimiento, estado, _TIPOSOCIO);
                    sacarDelSeguro++;
                }
            }

            MessageBox.Show("Se deben agregar al seguro " + nocoincidentes + " personas ", "Agregar" , MessageBoxButtons.OK ,MessageBoxIcon.Information);
            MessageBox.Show("Se deben sacar del seguro " + sacarDelSeguro + " personas ", "Quitar" , MessageBoxButtons.OK , MessageBoxIcon.Information);


            

            btnAgregarAseguro.Visible = true;
            btnSacarDelSeguro.Visible = true;
            ListaNoCoincidentes.Clear();
        }

      
    }
}
