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
    public partial class Consultas : Form
    {

        public Consultas()
        {
            InitializeComponent();
            MaximizeBox = false;
           

        }

        public int RUTGLOBAL = 0;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (txtRUT.Text.Equals(""))
            {
                txtRUT.Text = "0";
            }
            dataResultados.DataSource = null;
            dataResultados.Rows.Clear();
            lblinfo.Text = "Informaciòn";
            string RUTACONSULTAR = txtRUT.Text;
            int RUTINT = int.Parse(RUTACONSULTAR);

            DATAPJUDEntities db = new DATAPJUDEntities();

            var consultaEnTitulares = from cc in db.TITULARES where (cc.RUT == RUTINT) select cc;

            if (!consultaEnTitulares.Any())
            {
                MessageBox.Show("Socio no encontrado ",
                              "Socio no encontrado", MessageBoxButtons.OK,
                              MessageBoxIcon.Asterisk);

                lblinfo.Text = "Socio no encontrado";

                txtRUT1.Clear();
                txtDV.Clear();
                txtNombre.Clear();
                txtPaterno.Clear();
                txtMaterno.Clear();
                txtSexo.Clear();
                txtNacimiento.Clear();
                txtTipoSocio.Clear();
                txtFechaIngreso.Clear();
                txtCalJuridica.Clear();
                txtEstado.Clear();
                txtBanco.Clear();
                txtTipoCuenta.Clear();
                txtNCuenta.Clear();
                txtCorte.Clear();
                txtDescripcion.Clear();
                txtTribunal.Clear();
                txtDescripcion2.Clear();
                txtRegion.Clear();
                txtLocalidad.Clear();
                txtComuna.Clear();
                txtCalle.Clear();
                txtNumero.Clear();
                txtBlock.Clear();
                txtDepartamento.Clear();
                txtNotas.Clear();
            }
            else
            {
                RUTGLOBAL = RUTINT;

                foreach (var Q in consultaEnTitulares)
                {
                    txtRUT1.Text = Convert.ToString(Q.RUT);
                    txtDV.Text = Q.DV;

                    if (Q.DV.Equals("") || Q.DV.Equals(" "))
                    {
                        txtDV.Text = "K";
                    }
                    txtNombre.Text = Q.NOMBRES;
                    txtPaterno.Text = Q.PATERNO;
                    txtMaterno.Text = Q.MATERNO;
                    txtSexo.Text = Q.SEXO;
                    txtNacimiento.Text = Q.FECHANACIMIENTO.Substring(0, 10);
                    txtTipoSocio.Text = Q.TIPOSOCIO;
                    txtFechaIngreso.Text = Q.FECHAINGRESO.Substring(0, 10);
                    txtCalJuridica.Text = Q.CALJURIDICA;
                    txtEstado.Text = Q.ESTADO;
                    txtBanco.Text = Q.BANCO;
                    txtTipoCuenta.Text = Q.TIPOCUENTA;
                    txtNCuenta.Text = Q.NCUENTA;
                    txtCorte.Text = Q.CORTE;
                    txtDescripcion.Text = Q.DESCRIPCION;
                    txtTribunal.Text = Q.TRIBUNAL;
                    txtDescripcion2.Text = Q.DESCRIPCION2;
                    txtRegion.Text = Q.REGION;
                    txtLocalidad.Text = Q.LOCALIDAD;
                    txtComuna.Text = Q.COMUNA;
                    txtCalle.Text = Q.CALLE;
                    txtNumero.Text = Q.NUMERO;
                    txtBlock.Text = Q.BLOCK;
                    txtDepartamento.Text = Q.DEPARTAMENTO;
                    txtNotas.Clear();

                    var consultaEnCarga = from tt in db.CARGAS where (tt.RUTTITULAR == RUTINT) select tt;
                    if (!consultaEnCarga.Any())
                    {
                        lblinfo.Text = "Sin Cargas Asociadas";
                        dataResultados.Rows.Clear();

                    }
                    else
                    {
                        lblinfo.Text = "Cargas Asociadas";
                        dataResultados.DataSource = consultaEnCarga.ToList();
                        dataResultados.Columns[0].Visible = false;
                        dataResultados.Columns[1].Visible = false;
                        dataResultados.Columns[2].Visible = false;
                        dataResultados.Columns[3].Visible = false;
                        dataResultados.Columns[4].Visible = false;
                        dataResultados.Columns[5].Visible = false;
                        dataResultados.Columns[6].Visible = false;
                        dataResultados.Columns[16].Visible = false;
                        dataResultados.Columns[17].Visible = false;


                        for (int i = 0; i < dataResultados.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataResultados.Columns.Count; j++)
                            {
                                if (dataResultados.Rows[i].Cells[11].Value.ToString().Equals(""))
                                {
                                    dataResultados.Rows[i].Cells[11].Value = "K";
                                } //Linea de codigo añadida porque los RUT con Guion K los mostraba como
                                  // un espacio en blanco en DataGrid 

                                if (!dataResultados.Rows[i].Cells[12].Value.ToString().Equals(""))
                                {
                                    string FechaSinHora = dataResultados.Rows[i].Cells[12].Value.ToString();
                                    string resultado = FechaSinHora.Substring(0, 10);
                                    dataResultados.Rows[i].Cells[12].Value = resultado;
                                }

                                if (!dataResultados.Rows[i].Cells[13].Value.ToString().Equals(""))
                                {
                                    string FechaSinHora = dataResultados.Rows[i].Cells[13].Value.ToString();
                                    string resultado = FechaSinHora.Substring(0, 10);
                                    dataResultados.Rows[i].Cells[13].Value = resultado;
                                }

                                if (!dataResultados.Rows[i].Cells[14].Value.ToString().Equals(""))
                                {

                                    string FechaSinHora = dataResultados.Rows[i].Cells[14].Value.ToString();
                                    string resultado = FechaSinHora.Substring(0, 10);
                                    dataResultados.Rows[i].Cells[14].Value = resultado;
                                }

                            } //Cierre del primer For que recorre dataResultados

                        } //  //Cierre del segundo For que recorre dataResultados

                    } // Cierre del else que recorre DataResultados cuando la query devuelve resultado


                    var consultaEnNotas = from nn in db.NOTAS where (nn.RUTTITULAR == RUTINT) select nn;

                    if (!consultaEnNotas.Any())
                    {
                        lblNotaInfo.Text = "Sin notas asociadas";

                    }
                    else
                    {
                        lblNotaInfo.Text = "Tiene notas";


                        foreach (var N in consultaEnNotas)
                        {
                            txtNotas.Text = N.NOTA;
                        }
                    }

                }//Cierre del foreach que hace la consulta en Titulares 


            }
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (txtRUT1.Text.Length == 0)
            {
                MessageBox.Show("No hay un RUT en datos del titular",
                             "No hay un RUT en cados del titular", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            else
            {
                using (DATAPJUDEntities notanueva = new DATAPJUDEntities())
                {
                    NOTAS nota = new NOTAS();
                    nota.RUTTITULAR = RUTGLOBAL;
                    nota.NOTA = txtNotas.Text;

                    notanueva.NOTAS.Add(nota);
                    notanueva.SaveChanges();

                 
                    MessageBox.Show("Nota agregada",
                         "Nota Agregada", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

                }
            }
        }

        private void txtRUT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros",
                                "Solo se admiten numeros", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }

        }


    }
       
    }
