using System;
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
    public partial class CargarBase : Form
    {
        public CargarBase()
        {
            InitializeComponent();
             MaximizeBox = false;
            btnSigper.Visible = false;
            btnCarga.Visible = false;
            progressBar1.Visible = false; 
        }

        private void btnTitulares_Click(object sender, EventArgs e)
        {
            new ImportarTitulares().importartitulares(dataTitulares, "MaestrodeSocios");
            btnSigper.Visible = true; 
        }

        private void btnSigper_Click(object sender, EventArgs e)
        {
            new ImportarSigper().importarExcel(dataCargas, "CARGAS");
            btnCarga.Visible = true; 
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            DATAPJUDEntities contextDB3 = new DATAPJUDEntities();
            contextDB3.Database.ExecuteSqlCommand("Delete from TITULARES");
            contextDB3.Database.ExecuteSqlCommand("Delete from CARGAS");
            progressBar1.Visible = true; 

            foreach (DataGridViewRow row in dataTitulares.Rows)
            {
                /* 0 RUT*/
                string _RUTTITULAR = (row.Cells[0].Value.ToString());
                /* 1 DV*/
                int RUTINT = int.Parse(_RUTTITULAR);
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

                using (DATAPJUDEntities contextDB = new DATAPJUDEntities())
                {
                    TITULARES titularnuevo = new TITULARES();
                    titularnuevo.RUT = RUTINT;
                    titularnuevo.DV = _DVTITULAR;
                    titularnuevo.PATERNO = _APTITULAR;
                    titularnuevo.MATERNO = _AMTITULAR;
                    titularnuevo.NOMBRES = _NOMBRETITULAR;
                    titularnuevo.SEXO = _SEXO;
                    titularnuevo.FECHANACIMIENTO = _FECHADENACIMIENTO;
                    titularnuevo.TIPOSOCIO = _TIPOSOCIO;
                    titularnuevo.FECHAINGRESO = _FECHAINGRESO;
                    titularnuevo.CALJURIDICA = _CALJURIDICA;
                    titularnuevo.CORTE = _CORTE;
                    titularnuevo.DESCRIPCION = _DESCRIPCION;
                    titularnuevo.TRIBUNAL = _TRIBUNAL;
                    titularnuevo.DESCRIPCION2 = _DESCRIPCION2;
                    titularnuevo.TIPOCUENTA = _TIPOCUENTA;
                    titularnuevo.BANCO = _BANCO;
                    titularnuevo.NCUENTA = _NCUENTA;
                    titularnuevo.EMAIL = _EMAIL;
                    titularnuevo.ESTADO = _ESTADO;
                    titularnuevo.COMUNA = _COMUNA;
                    titularnuevo.LOCALIDAD = _LOCALIDAD;
                    titularnuevo.REGION = _REGION;
                    titularnuevo.CALLE = _CALLE;
                    titularnuevo.NUMERO = _NUMERO;
                    titularnuevo.BLOCK = _BLOCK;
                    titularnuevo.DEPARTAMENTO = _DEPARTAMENTO;

                    contextDB.TITULARES.Add(titularnuevo);
                    contextDB.SaveChanges();
                }

                progressBar1.Increment(1); 


            }


            foreach (DataGridViewRow row in dataCargas.Rows)
            {

                string _RUTTITULAR = (row.Cells[0].Value.ToString());
                int RUTINT = int.Parse(_RUTTITULAR);
                string _DVTITULAR = (row.Cells[1].Value.ToString());
                string _NOMBRETITULAR = (row.Cells[4].Value.ToString());
                string _AP_TITULAR = (row.Cells[2].Value.ToString());
                string _AM_TITULAR = (row.Cells[3].Value.ToString());
                string _TIPOSOCIO = (row.Cells[5].Value.ToString());
                string Nombres = (row.Cells[12].Value.ToString());
                string ApellidoPaterno = (row.Cells[10].Value.ToString());
                string ApellidoMaterno = (row.Cells[11].Value.ToString());
                string RUTCARGA = (row.Cells[8].Value.ToString());
                int RUTCARGAINT = int.Parse(RUTCARGA);
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

                    using (DATAPJUDEntities contextDB4 = new DATAPJUDEntities())
                    {
                        CARGAS carganueva = new CARGAS();

                        carganueva.RUTTITULAR = RUTINT;
                        carganueva.DVTITULAR = _DVTITULAR;
                        carganueva.NOMBRETITULAR = _NOMBRETITULAR;
                        carganueva.AP_TITULAR = _AP_TITULAR;
                        carganueva.AM_TITULAR = _AM_TITULAR;
                        carganueva.TIPOSOCIO = _TIPOSOCIO;

                        carganueva.NOMBRECARGA = Nombres;
                        carganueva.AP_CARGA = ApellidoPaterno;
                        carganueva.AM_CARGA = ApellidoMaterno;
                        carganueva.RUTCARGA = RUTCARGAINT;
                        carganueva.DVCARGA = _DVCARGA;

                        carganueva.FECHAINICIO = fechaInicio;
                        carganueva.FECHATERMINO = fechaTermino;
                        carganueva.FECHANACIMIENTO = fechaNacimiento;
                        carganueva.ESTADO = estado;


                        contextDB4.CARGAS.Add(carganueva);
                        contextDB4.SaveChanges();
                    }


                }

                progressBar1.Increment(1);

            }


            MessageBox.Show("Base cargada",
                 "Base Cargada", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }
    }
}
