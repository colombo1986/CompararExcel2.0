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
    public partial class ComparaTitulares : Form
    {
    
        
          
        public ComparaTitulares()
        {
            InitializeComponent();
            MaximizeBox = false;

            //Se añade una fila invisible al DataGrid 3 y 4 para que luego aparezca en el excel exportado
            //RUT-0        DV-1   PATERNO-2  MATERNO-3  NOMBRES-4  SEXO-5  FECHA DE NACIMIENTO-6  TIPO DE SOCIO-7   FECHA DE INGRESO-8  CAL.JURIDICA-9  CORTE-10  DESCRIPCIÓN-11 TRIBUNAL-12   DESCRIPCION-13  TIPO CUENTA-14  BANCO-15 N° CUENTA-16 E-MAIL-17  ESTADO-18   COMUNA-19  LOCALIDAD-20  REGION-21 CALLE-22   NUMERO-23  BLOCK-24 DEPARTAMENTO-25

            dataTitulares2.Rows.Add("RUT_TITULAR", "DV", "PATERNO", "MATERNO", "NOMBRES", "SEXO", "FECHA DE NACIMIENTO", "TIPO DE SOCIO", "FECHA DE INGRESO", "CAL. JURIDICA", "CORTE", "DESCRIPCIÓN", "TRIBUNAL", "DESCRIPCION", "TIPO CUENTA", "BANCO", "N° CUENTA", "E-MAIL", "ESTADO", "COMUNA", "LOCALIDAD", "REGION", "CALLE", "NUMERO", "BLOCK", "DEPARTAMENTO");
            dataTitulares2.Rows[0].Visible = true;
            dataTitulares2.Rows[0].Visible = false;
            btnSeguro.Visible = false;
            btnCompara.Visible = false;
            ExportarTitulares.Visible = false; 
        }

        private void ComparaTitulares_Load(object sender, EventArgs e)
        {

        }


        private void btnTitulares_Click(object sender, EventArgs e)
        {
            new ImportarTitulares().importartitulares(dataTitulares, "MaestrodeSocios");
            btnSeguro.Visible = true; 
        }

        private void btnSeguro_Click(object sender, EventArgs e)
        {
            new ImportarSeguro().importarExcelSeguro(dataBCI, "BCI");
            btnCompara.Visible = true; 
        }

        private void ExportarTitulares_Click(object sender, EventArgs e)
        {
            new ExportarTitularesNuevos().TitularesNuevos(dataTitulares2);
        }
      
        private void btnCompara_Click(object sender, EventArgs e)
        {
            int nocoincidentes = 0;
            ArrayList ListaCoincidentes = new ArrayList();

            foreach (DataGridViewRow row2 in dataBCI.Rows)
            {
                string RUTSEGURO = row2.Cells[9].Value.ToString();
                ListaCoincidentes.Add(RUTSEGURO);

            }

            foreach (DataGridViewRow row in dataTitulares.Rows)
            {
                
                /* 0 RUT*/
                string _RUTTITULAR = (row.Cells[0].Value.ToString());
                /* 1 DV*/
                string _DVTITULAR = (row.Cells[1].Value.ToString());
                /*2 PATERNO*/
                string _APTITULAR = (row.Cells[2].Value.ToString());
                /* 3 MATERNO*/
                string _AMTITULAR = (row.Cells[3].Value.ToString());
                /*4 NOMBRES*/
                string _NOMBRETITULAR = (row.Cells[4].Value.ToString());
                /* 5 SEXO  */
                string _SEXO = (row.Cells[5].Value.ToString());
                /* 6 FECHA DE NACIMIENTO*/
                string _FECHADENACIMIENTO = (row.Cells[6].Value.ToString());
                /* 7 TIPO DE SOCIO  */
                string _TIPOSOCIO = (row.Cells[7].Value.ToString());
                /*8 FECHA DE INGRESO BIENESTAR*/
                string _FECHAINGRESO = (row.Cells[8].Value.ToString());
                /*  9 CAL.JURIDICA    */
                string _CALJURIDICA = (row.Cells[9].Value.ToString());
                /* 10 CORTE */
                string _CORTE = (row.Cells[10].Value.ToString());
                /*11 DESCRIPCIÓN    */
                string _DESCRIPCION = (row.Cells[11].Value.ToString());
                /*12 TRIBUNAL */
                string _TRIBUNAL = (row.Cells[12].Value.ToString());
                /*13 DESCRIPCION */
                string _DESCRIPCION2 = (row.Cells[13].Value.ToString());
                /*14 TIPO CUENTA     */
                string _TIPOCUENTA = (row.Cells[14].Value.ToString());
                /*15 BANCO */
                string _BANCO = (row.Cells[15].Value.ToString());
                /*16 N° CUENTA*/
                string _NCUENTA = (row.Cells[16].Value.ToString());
                /* 17 E - MAIL  */
                string _EMAIL = (row.Cells[17].Value.ToString());
                /*18 ESTADO FUNCIONARIO*/
                string _ESTADO = (row.Cells[18].Value.ToString());
                /*19 COMUNA    */
                string _COMUNA = (row.Cells[19].Value.ToString());
                /* 20 LOCALIDAD   */
                string _LOCALIDAD = (row.Cells[20].Value.ToString());
                /*21 REGION*/
                string _REGION = (row.Cells[21].Value.ToString());
                /*22 CALLE  */
                string _CALLE = (row.Cells[22].Value.ToString());
                /*23   NUMERO  */
                string _NUMERO = (row.Cells[23].Value.ToString());
                /*24 BLOCK  */
                string _BLOCK = (row.Cells[24].Value.ToString());
                /*25 DEPARTAMENTO*/
                string _DEPARTAMENTO = (row.Cells[25].Value.ToString());

                if (ListaCoincidentes.Contains(_RUTTITULAR))
                {
                    // No hace nada
                }
                else
                {
                    //Agrega los que no estan al dataResultados
                    //RUT       DV          PATERNO    MATERNO  NOMBRES      SEXO  FECHA DE NACIMIENTO  TIPO DE SOCIO FECHA DE INGRESO BIENESTAR  CAL.JURIDICA   CORTE  DESCRIPCIÓN   TRIBUNAL   DESCRIPCION  TIPO CUENTA   BANCO  N° CUENTA   E-MAIL ESTADO  COMUNA  LOCALIDAD   REGION CALLE   NUMERO   BLOCK    DEPARTAMENTO
                    dataTitulares2.Rows.Add(_RUTTITULAR, _DVTITULAR, _APTITULAR, _AMTITULAR, _NOMBRETITULAR, _SEXO, _FECHADENACIMIENTO, _TIPOSOCIO, _FECHAINGRESO, _CALJURIDICA, _CORTE, _DESCRIPCION, _TRIBUNAL, _DESCRIPCION2, _TIPOCUENTA, _BANCO, _NCUENTA, _EMAIL, _ESTADO, _COMUNA, _LOCALIDAD, _REGION, _CALLE, _NUMERO, _BLOCK, _DEPARTAMENTO);
                    nocoincidentes++;
                }

                  progressBar1.Increment(1);
            }

          
            MessageBox.Show("Se deben agregar al seguro " + nocoincidentes + " socios nuevos ",
                            "Se deben agregar al seguro " + nocoincidentes + " socios nuevos ", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                             ExportarTitulares.Visible = true; 
        }

      
    }
}
