using System.Windows.Forms;

namespace CompararExcel2._0
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.grpTitular = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDV = new System.Windows.Forms.Label();
            this.lblRUT = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtRUT1 = new System.Windows.Forms.TextBox();
            this.grpBien = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCalJuridica = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblTipoSocio = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCalJuridica = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtTipoSocio = new System.Windows.Forms.TextBox();
            this.grpBanco = new System.Windows.Forms.GroupBox();
            this.txtNCuenta = new System.Windows.Forms.TextBox();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblNCuenta = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.grpUbicacion = new System.Windows.Forms.GroupBox();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblTribunal = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCorte = new System.Windows.Forms.Label();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.txtTribunal = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCorte = new System.Windows.Forms.TextBox();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblComuna = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtComuna = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.grpCargas = new System.Windows.Forms.GroupBox();
            this.dataResultados = new System.Windows.Forms.DataGridView();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblNotaInfo = new System.Windows.Forms.Label();
            this.panelConsulta.SuspendLayout();
            this.grpTitular.SuspendLayout();
            this.grpBien.SuspendLayout();
            this.grpBanco.SuspendLayout();
            this.grpUbicacion.SuspendLayout();
            this.grpDireccion.SuspendLayout();
            this.grpCargas.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConsulta.Controls.Add(this.btnGuardarNota);
            this.panelConsulta.Controls.Add(this.txtNotas);
            this.panelConsulta.Location = new System.Drawing.Point(12, 637);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(684, 73);
            this.panelConsulta.TabIndex = 0;
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Location = new System.Drawing.Point(574, 3);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(91, 59);
            this.btnGuardarNota.TabIndex = 2;
            this.btnGuardarNota.Text = "Guardar";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(3, 5);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(562, 59);
            this.txtNotas.TabIndex = 1;
            // 
            // txtRUT
            // 
            this.txtRUT.Location = new System.Drawing.Point(15, 27);
            this.txtRUT.Name = "txtRUT";
            this.txtRUT.Size = new System.Drawing.Size(195, 20);
            this.txtRUT.TabIndex = 1;
            this.txtRUT.Text = "0";
            this.txtRUT.TextChanged += new System.EventHandler(this.txtRUT_TextChanged);
            this.txtRUT.KeyPress += new KeyPressEventHandler(this.txtRUT_KeyPress);

            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsulta.Location = new System.Drawing.Point(244, 18);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(103, 36);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(12, 50);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(198, 13);
            this.lblinfo.TabIndex = 3;
            this.lblinfo.Text = "Ingrese Rut del titular sin puntos ni guión";
            // 
            // grpTitular
            // 
            this.grpTitular.Controls.Add(this.lblEmail);
            this.grpTitular.Controls.Add(this.lblNacimiento);
            this.grpTitular.Controls.Add(this.lblSexo);
            this.grpTitular.Controls.Add(this.lblMaterno);
            this.grpTitular.Controls.Add(this.lblPaterno);
            this.grpTitular.Controls.Add(this.lblNombre);
            this.grpTitular.Controls.Add(this.lblDV);
            this.grpTitular.Controls.Add(this.lblRUT);
            this.grpTitular.Controls.Add(this.txtEmail);
            this.grpTitular.Controls.Add(this.txtNacimiento);
            this.grpTitular.Controls.Add(this.txtSexo);
            this.grpTitular.Controls.Add(this.txtMaterno);
            this.grpTitular.Controls.Add(this.txtPaterno);
            this.grpTitular.Controls.Add(this.txtNombre);
            this.grpTitular.Controls.Add(this.txtDV);
            this.grpTitular.Controls.Add(this.txtRUT1);
            this.grpTitular.Location = new System.Drawing.Point(15, 66);
            this.grpTitular.Name = "grpTitular";
            this.grpTitular.Size = new System.Drawing.Size(319, 219);
            this.grpTitular.TabIndex = 4;
            this.grpTitular.TabStop = false;
            this.grpTitular.Text = "Datos del Titular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(13, 160);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblNacimiento.TabIndex = 14;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(13, 133);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(13, 108);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblMaterno.TabIndex = 12;
            this.lblMaterno.Text = "Apellido Materno";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(13, 80);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblPaterno.TabIndex = 11;
            this.lblPaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombres";
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(257, 24);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(10, 13);
            this.lblDV.TabIndex = 9;
            this.lblDV.Text = "-";
            // 
            // lblRUT
            // 
            this.lblRUT.AutoSize = true;
            this.lblRUT.Location = new System.Drawing.Point(13, 26);
            this.lblRUT.Name = "lblRUT";
            this.lblRUT.Size = new System.Drawing.Size(30, 13);
            this.lblRUT.TabIndex = 8;
            this.lblRUT.Text = "RUT";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(127, 153);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(174, 20);
            this.txtNacimiento.TabIndex = 6;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(127, 127);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(174, 20);
            this.txtSexo.TabIndex = 5;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(127, 101);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(174, 20);
            this.txtMaterno.TabIndex = 4;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(127, 73);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(174, 20);
            this.txtPaterno.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(273, 21);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(28, 20);
            this.txtDV.TabIndex = 1;
            // 
            // txtRUT1
            // 
            this.txtRUT1.Location = new System.Drawing.Point(127, 19);
            this.txtRUT1.Name = "txtRUT1";
            this.txtRUT1.Size = new System.Drawing.Size(124, 20);
            this.txtRUT1.TabIndex = 0;
            this.txtRUT1.Text = "0";
            this.txtRUT1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // grpBien
            // 
            this.grpBien.Controls.Add(this.lblEstado);
            this.grpBien.Controls.Add(this.lblCalJuridica);
            this.grpBien.Controls.Add(this.lblIngreso);
            this.grpBien.Controls.Add(this.lblTipoSocio);
            this.grpBien.Controls.Add(this.txtEstado);
            this.grpBien.Controls.Add(this.txtCalJuridica);
            this.grpBien.Controls.Add(this.txtFechaIngreso);
            this.grpBien.Controls.Add(this.txtTipoSocio);
            this.grpBien.Location = new System.Drawing.Point(340, 66);
            this.grpBien.Name = "grpBien";
            this.grpBien.Size = new System.Drawing.Size(356, 219);
            this.grpBien.TabIndex = 5;
            this.grpBien.TabStop = false;
            this.grpBien.Text = "Datos en Bienestar";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // lblCalJuridica
            // 
            this.lblCalJuridica.AutoSize = true;
            this.lblCalJuridica.Location = new System.Drawing.Point(13, 81);
            this.lblCalJuridica.Name = "lblCalJuridica";
            this.lblCalJuridica.Size = new System.Drawing.Size(78, 13);
            this.lblCalJuridica.TabIndex = 6;
            this.lblCalJuridica.Text = "Calidad juridica";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(10, 56);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblIngreso.TabIndex = 5;
            this.lblIngreso.Text = "Fecha de Ingreso";
            // 
            // lblTipoSocio
            // 
            this.lblTipoSocio.AutoSize = true;
            this.lblTipoSocio.Location = new System.Drawing.Point(10, 30);
            this.lblTipoSocio.Name = "lblTipoSocio";
            this.lblTipoSocio.Size = new System.Drawing.Size(71, 13);
            this.lblTipoSocio.TabIndex = 4;
            this.lblTipoSocio.Text = "Tipo de socio";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(149, 108);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(174, 91);
            this.txtEstado.TabIndex = 3;
            // 
            // txtCalJuridica
            // 
            this.txtCalJuridica.Location = new System.Drawing.Point(149, 75);
            this.txtCalJuridica.Name = "txtCalJuridica";
            this.txtCalJuridica.Size = new System.Drawing.Size(174, 20);
            this.txtCalJuridica.TabIndex = 2;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(149, 49);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(174, 20);
            this.txtFechaIngreso.TabIndex = 1;
            // 
            // txtTipoSocio
            // 
            this.txtTipoSocio.Location = new System.Drawing.Point(149, 23);
            this.txtTipoSocio.Name = "txtTipoSocio";
            this.txtTipoSocio.Size = new System.Drawing.Size(174, 20);
            this.txtTipoSocio.TabIndex = 0;
            // 
            // grpBanco
            // 
            this.grpBanco.Controls.Add(this.txtNCuenta);
            this.grpBanco.Controls.Add(this.txtTipoCuenta);
            this.grpBanco.Controls.Add(this.txtBanco);
            this.grpBanco.Controls.Add(this.lblNCuenta);
            this.grpBanco.Controls.Add(this.lblTipoCuenta);
            this.grpBanco.Controls.Add(this.lblBanco);
            this.grpBanco.Location = new System.Drawing.Point(15, 291);
            this.grpBanco.Name = "grpBanco";
            this.grpBanco.Size = new System.Drawing.Size(681, 62);
            this.grpBanco.TabIndex = 6;
            this.grpBanco.TabStop = false;
            this.grpBanco.Text = "Datos del Banco";
            // 
            // txtNCuenta
            // 
            this.txtNCuenta.Location = new System.Drawing.Point(485, 31);
            this.txtNCuenta.Name = "txtNCuenta";
            this.txtNCuenta.Size = new System.Drawing.Size(190, 20);
            this.txtNCuenta.TabIndex = 5;
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(273, 31);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Size = new System.Drawing.Size(133, 20);
            this.txtTipoCuenta.TabIndex = 4;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(48, 31);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(148, 20);
            this.txtBanco.TabIndex = 3;
            // 
            // lblNCuenta
            // 
            this.lblNCuenta.AutoSize = true;
            this.lblNCuenta.Location = new System.Drawing.Point(423, 37);
            this.lblNCuenta.Name = "lblNCuenta";
            this.lblNCuenta.Size = new System.Drawing.Size(56, 13);
            this.lblNCuenta.TabIndex = 2;
            this.lblNCuenta.Text = "N° Cuenta";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(202, 38);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(65, 13);
            this.lblTipoCuenta.TabIndex = 1;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(3, 37);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 0;
            this.lblBanco.Text = "Banco";
            // 
            // grpUbicacion
            // 
            this.grpUbicacion.Controls.Add(this.lblDescripcion2);
            this.grpUbicacion.Controls.Add(this.lblTribunal);
            this.grpUbicacion.Controls.Add(this.lblDescripcion);
            this.grpUbicacion.Controls.Add(this.lblCorte);
            this.grpUbicacion.Controls.Add(this.txtDescripcion2);
            this.grpUbicacion.Controls.Add(this.txtTribunal);
            this.grpUbicacion.Controls.Add(this.txtDescripcion);
            this.grpUbicacion.Controls.Add(this.txtCorte);
            this.grpUbicacion.Location = new System.Drawing.Point(15, 359);
            this.grpUbicacion.Name = "grpUbicacion";
            this.grpUbicacion.Size = new System.Drawing.Size(332, 148);
            this.grpUbicacion.TabIndex = 7;
            this.grpUbicacion.TabStop = false;
            this.grpUbicacion.Text = "Lugar de trabajo";
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Location = new System.Drawing.Point(13, 104);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(72, 13);
            this.lblDescripcion2.TabIndex = 7;
            this.lblDescripcion2.Text = "Descripcion 2";
            // 
            // lblTribunal
            // 
            this.lblTribunal.AutoSize = true;
            this.lblTribunal.Location = new System.Drawing.Point(13, 78);
            this.lblTribunal.Name = "lblTribunal";
            this.lblTribunal.Size = new System.Drawing.Size(45, 13);
            this.lblTribunal.TabIndex = 6;
            this.lblTribunal.Text = "Tribunal";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 52);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCorte
            // 
            this.lblCorte.AutoSize = true;
            this.lblCorte.Location = new System.Drawing.Point(13, 26);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(32, 13);
            this.lblCorte.TabIndex = 4;
            this.lblCorte.Text = "Corte";
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(165, 97);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(154, 20);
            this.txtDescripcion2.TabIndex = 3;
            // 
            // txtTribunal
            // 
            this.txtTribunal.Location = new System.Drawing.Point(165, 71);
            this.txtTribunal.Name = "txtTribunal";
            this.txtTribunal.Size = new System.Drawing.Size(154, 20);
            this.txtTribunal.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(165, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(154, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtCorte
            // 
            this.txtCorte.Location = new System.Drawing.Point(165, 19);
            this.txtCorte.Name = "txtCorte";
            this.txtCorte.Size = new System.Drawing.Size(154, 20);
            this.txtCorte.TabIndex = 0;
            // 
            // grpDireccion
            // 
            this.grpDireccion.Controls.Add(this.lblDepartamento);
            this.grpDireccion.Controls.Add(this.lblBlock);
            this.grpDireccion.Controls.Add(this.txtDepartamento);
            this.grpDireccion.Controls.Add(this.txtBlock);
            this.grpDireccion.Controls.Add(this.txtNumero);
            this.grpDireccion.Controls.Add(this.label1);
            this.grpDireccion.Controls.Add(this.lblCalle);
            this.grpDireccion.Controls.Add(this.lblComuna);
            this.grpDireccion.Controls.Add(this.lblLocalidad);
            this.grpDireccion.Controls.Add(this.lblRegion);
            this.grpDireccion.Controls.Add(this.txtCalle);
            this.grpDireccion.Controls.Add(this.txtComuna);
            this.grpDireccion.Controls.Add(this.txtLocalidad);
            this.grpDireccion.Controls.Add(this.txtRegion);
            this.grpDireccion.Location = new System.Drawing.Point(353, 359);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(343, 148);
            this.grpDireccion.TabIndex = 8;
            this.grpDireccion.TabStop = false;
            this.grpDireccion.Text = "Dirección personal";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(206, 126);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 13;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(29, 126);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(34, 13);
            this.lblBlock.TabIndex = 12;
            this.lblBlock.Text = "Block";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(295, 123);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(42, 20);
            this.txtDepartamento.TabIndex = 11;
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(88, 123);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(100, 20);
            this.txtBlock.TabIndex = 10;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(295, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "N°";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(29, 100);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 7;
            this.lblCalle.Text = "Calle";
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(29, 74);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(46, 13);
            this.lblComuna.TabIndex = 6;
            this.lblComuna.Text = "Comuna";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(29, 48);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 5;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(29, 22);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Región";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(88, 97);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(176, 20);
            this.txtCalle.TabIndex = 3;
            // 
            // txtComuna
            // 
            this.txtComuna.Location = new System.Drawing.Point(88, 71);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(249, 20);
            this.txtComuna.TabIndex = 2;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(88, 45);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(249, 20);
            this.txtLocalidad.TabIndex = 1;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(88, 19);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(249, 20);
            this.txtRegion.TabIndex = 0;
            // 
            // grpCargas
            // 
            this.grpCargas.Controls.Add(this.dataResultados);
            this.grpCargas.Location = new System.Drawing.Point(15, 513);
            this.grpCargas.Name = "grpCargas";
            this.grpCargas.Size = new System.Drawing.Size(681, 105);
            this.grpCargas.TabIndex = 9;
            this.grpCargas.TabStop = false;
            this.grpCargas.Text = "Cargas asociadas";
            // 
            // dataResultados
            // 
            this.dataResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultados.Location = new System.Drawing.Point(6, 19);
            this.dataResultados.Name = "dataResultados";
            this.dataResultados.Size = new System.Drawing.Size(669, 80);
            this.dataResultados.TabIndex = 0;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(18, 621);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(89, 13);
            this.lblNotas.TabIndex = 10;
            this.lblNotas.Text = "Notas de la mesa";
            // 
            // lblNotaInfo
            // 
            this.lblNotaInfo.AutoSize = true;
            this.lblNotaInfo.Location = new System.Drawing.Point(601, 621);
            this.lblNotaInfo.Name = "lblNotaInfo";
            this.lblNotaInfo.Size = new System.Drawing.Size(62, 13);
            this.lblNotaInfo.TabIndex = 11;
            this.lblNotaInfo.Text = "Información";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 711);
            this.Controls.Add(this.lblNotaInfo);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.grpCargas);
            this.Controls.Add(this.grpDireccion);
            this.Controls.Add(this.grpUbicacion);
            this.Controls.Add(this.grpBanco);
            this.Controls.Add(this.grpBien);
            this.Controls.Add(this.grpTitular);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtRUT);
            this.Controls.Add(this.panelConsulta);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            this.grpTitular.ResumeLayout(false);
            this.grpTitular.PerformLayout();
            this.grpBien.ResumeLayout(false);
            this.grpBien.PerformLayout();
            this.grpBanco.ResumeLayout(false);
            this.grpBanco.PerformLayout();
            this.grpUbicacion.ResumeLayout(false);
            this.grpUbicacion.PerformLayout();
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            this.grpCargas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox grpTitular;
        private System.Windows.Forms.GroupBox grpBien;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtRUT1;
        private System.Windows.Forms.GroupBox grpBanco;
        private System.Windows.Forms.GroupBox grpUbicacion;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.GroupBox grpCargas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Label lblRUT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCalJuridica;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblTipoSocio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCalJuridica;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtTipoSocio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNCuenta;
        private System.Windows.Forms.TextBox txtTipoCuenta;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblNCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblTribunal;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.TextBox txtTribunal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCorte;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblComuna;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtComuna;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.DataGridView dataResultados;
        private System.Windows.Forms.Label lblNotaInfo;
    }
}