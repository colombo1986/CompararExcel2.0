namespace CompararExcel2._0
{
    partial class ComparaTitulares
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
            this.dataTitulares = new System.Windows.Forms.DataGridView();
            this.btnTitulares = new System.Windows.Forms.Button();
            this.btnSeguro = new System.Windows.Forms.Button();
            this.dataBCI = new System.Windows.Forms.DataGridView();
            this.btnCompara = new System.Windows.Forms.Button();
            this.dataTitulares2 = new System.Windows.Forms.DataGridView();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAL_JURIDICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRIBUNAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMUNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarTitulares = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataTitulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTitulares2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTitulares
            // 
            this.dataTitulares.AllowUserToAddRows = false;
            this.dataTitulares.AllowUserToDeleteRows = false;
            this.dataTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTitulares.Location = new System.Drawing.Point(23, 47);
            this.dataTitulares.Name = "dataTitulares";
            this.dataTitulares.Size = new System.Drawing.Size(576, 241);
            this.dataTitulares.TabIndex = 5;
            // 
            // btnTitulares
            // 
            this.btnTitulares.Location = new System.Drawing.Point(23, 12);
            this.btnTitulares.Name = "btnTitulares";
            this.btnTitulares.Size = new System.Drawing.Size(576, 29);
            this.btnTitulares.TabIndex = 6;
            this.btnTitulares.Text = "Adjuntar Excel de Sigper [MAESTRO SOCIOS]";
            this.btnTitulares.UseVisualStyleBackColor = true;
            this.btnTitulares.Click += new System.EventHandler(this.btnTitulares_Click);
            // 
            // btnSeguro
            // 
            this.btnSeguro.Location = new System.Drawing.Point(674, 12);
            this.btnSeguro.Name = "btnSeguro";
            this.btnSeguro.Size = new System.Drawing.Size(587, 29);
            this.btnSeguro.TabIndex = 9;
            this.btnSeguro.Text = "Adjuntar Excel del Seguro [PLANILLA BCI]";
            this.btnSeguro.UseVisualStyleBackColor = true;
            this.btnSeguro.Click += new System.EventHandler(this.btnSeguro_Click);
            // 
            // dataBCI
            // 
            this.dataBCI.AllowUserToAddRows = false;
            this.dataBCI.AllowUserToDeleteRows = false;
            this.dataBCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBCI.Location = new System.Drawing.Point(674, 47);
            this.dataBCI.Name = "dataBCI";
            this.dataBCI.Size = new System.Drawing.Size(580, 241);
            this.dataBCI.TabIndex = 10;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(331, 294);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(569, 23);
            this.btnCompara.TabIndex = 11;
            this.btnCompara.Text = "Compara datos";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // dataTitulares2
            // 
            this.dataTitulares2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTitulares2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUT,
            this.DV,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRES,
            this.SEXO,
            this.FECHANACIMIENTO,
            this.TIPO,
            this.FECHAINGRESO,
            this.CAL_JURIDICA,
            this.CORTE,
            this.DESCRIPCION,
            this.TRIBUNAL,
            this.DESCRIPCION2,
            this.TIPOCUENTA,
            this.BANCO,
            this.NCUENTA,
            this.EMAIL,
            this.ESTADO,
            this.COMUNA,
            this.LOCALIDAD,
            this.REGION,
            this.CALLE,
            this.NUMERO,
            this.BLOCK,
            this.DEPARTAMENTO});
            this.dataTitulares2.Location = new System.Drawing.Point(23, 352);
            this.dataTitulares2.Name = "dataTitulares2";
            this.dataTitulares2.Size = new System.Drawing.Size(1231, 216);
            this.dataTitulares2.TabIndex = 13;
            // 
            // RUT
            // 
            this.RUT.HeaderText = "RUT";
            this.RUT.Name = "RUT";
            // 
            // DV
            // 
            this.DV.HeaderText = "DV";
            this.DV.Name = "DV";
            // 
            // PATERNO
            // 
            this.PATERNO.HeaderText = "PATERNO";
            this.PATERNO.Name = "PATERNO";
            // 
            // MATERNO
            // 
            this.MATERNO.HeaderText = "MATERNO";
            this.MATERNO.Name = "MATERNO";
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            // 
            // FECHANACIMIENTO
            // 
            this.FECHANACIMIENTO.HeaderText = "FECHANACIMIENTO";
            this.FECHANACIMIENTO.Name = "FECHANACIMIENTO";
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.HeaderText = "FECHAINGRESO";
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            // 
            // CAL_JURIDICA
            // 
            this.CAL_JURIDICA.HeaderText = "CAL_JURIDICA";
            this.CAL_JURIDICA.Name = "CAL_JURIDICA";
            // 
            // CORTE
            // 
            this.CORTE.HeaderText = "CORTE";
            this.CORTE.Name = "CORTE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // TRIBUNAL
            // 
            this.TRIBUNAL.HeaderText = "TRIBUNAL";
            this.TRIBUNAL.Name = "TRIBUNAL";
            // 
            // DESCRIPCION2
            // 
            this.DESCRIPCION2.HeaderText = "DESCRIPCION";
            this.DESCRIPCION2.Name = "DESCRIPCION2";
            // 
            // TIPOCUENTA
            // 
            this.TIPOCUENTA.HeaderText = "TIPOCUENTA";
            this.TIPOCUENTA.Name = "TIPOCUENTA";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // NCUENTA
            // 
            this.NCUENTA.HeaderText = "N° CUENTA";
            this.NCUENTA.Name = "NCUENTA";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "E-MAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // COMUNA
            // 
            this.COMUNA.HeaderText = "COMUNA";
            this.COMUNA.Name = "COMUNA";
            // 
            // LOCALIDAD
            // 
            this.LOCALIDAD.HeaderText = "LOCALIDAD";
            this.LOCALIDAD.Name = "LOCALIDAD";
            // 
            // REGION
            // 
            this.REGION.HeaderText = "REGION";
            this.REGION.Name = "REGION";
            // 
            // CALLE
            // 
            this.CALLE.HeaderText = "CALLE";
            this.CALLE.Name = "CALLE";
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NUMERO";
            this.NUMERO.Name = "NUMERO";
            // 
            // BLOCK
            // 
            this.BLOCK.HeaderText = "BLOCK";
            this.BLOCK.Name = "BLOCK";
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            // 
            // ExportarTitulares
            // 
            this.ExportarTitulares.Location = new System.Drawing.Point(467, 582);
            this.ExportarTitulares.Name = "ExportarTitulares";
            this.ExportarTitulares.Size = new System.Drawing.Size(356, 23);
            this.ExportarTitulares.TabIndex = 15;
            this.ExportarTitulares.Text = "Exportar a Excel";
            this.ExportarTitulares.UseVisualStyleBackColor = true;
            this.ExportarTitulares.Click += new System.EventHandler(this.ExportarTitulares_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Yellow;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(23, 323);
            this.progressBar1.Maximum = 8500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1228, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // ComparaTitulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 614);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ExportarTitulares);
            this.Controls.Add(this.dataTitulares2);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.dataBCI);
            this.Controls.Add(this.btnSeguro);
            this.Controls.Add(this.btnTitulares);
            this.Controls.Add(this.dataTitulares);
            this.Name = "ComparaTitulares";
            this.Text = "ComparaTitulares";
            this.Load += new System.EventHandler(this.ComparaTitulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTitulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTitulares2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTitulares;
        private System.Windows.Forms.Button btnTitulares;
        private System.Windows.Forms.Button btnSeguro;
        private System.Windows.Forms.DataGridView dataBCI;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.DataGridView dataTitulares2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAL_JURIDICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRIBUNAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMUNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.Button ExportarTitulares;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}