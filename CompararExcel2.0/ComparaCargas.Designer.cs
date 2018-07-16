namespace CompararExcel2._0
{
    partial class ComparaCargas
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
            this.btnSigper = new System.Windows.Forms.Button();
            this.dataCargas = new System.Windows.Forms.DataGridView();
            this.dataBCI = new System.Windows.Forms.DataGridView();
            this.btnSeguro = new System.Windows.Forms.Button();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnAgregarAseguro = new System.Windows.Forms.Button();
            this.btnSacarDelSeguro = new System.Windows.Forms.Button();
            this.dataAgregarAseguro = new System.Windows.Forms.DataGridView();
            this.RUT_TITULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV_TITULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_TITULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_TITULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AM_TITULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECARGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTCARGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVCARGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHATERMINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOSOCIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSacarDelSeguro = new System.Windows.Forms.DataGridView();
            this.RUT_TITULARDG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV_TITULARDG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_TITULARDG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_TITULARDG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AM_TITULARDG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRESDG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOPATERNODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOMATERNODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTCARGADG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVCARGADG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINICIODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHATERMINODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANACIMIENTODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOSOCIODG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataCargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgregarAseguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSacarDelSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSigper
            // 
            this.btnSigper.Location = new System.Drawing.Point(12, 12);
            this.btnSigper.Name = "btnSigper";
            this.btnSigper.Size = new System.Drawing.Size(547, 29);
            this.btnSigper.TabIndex = 2;
            this.btnSigper.Text = "Adjuntar Excel de Sigper [CARGAS BIENESTAR]";
            this.btnSigper.UseVisualStyleBackColor = true;
            this.btnSigper.Click += new System.EventHandler(this.btnSigper_Click);
            // 
            // dataCargas
            // 
            this.dataCargas.AllowUserToAddRows = false;
            this.dataCargas.AllowUserToDeleteRows = false;
            this.dataCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCargas.Location = new System.Drawing.Point(12, 47);
            this.dataCargas.Name = "dataCargas";
            this.dataCargas.ReadOnly = true;
            this.dataCargas.Size = new System.Drawing.Size(547, 248);
            this.dataCargas.TabIndex = 5;
            // 
            // dataBCI
            // 
            this.dataBCI.AllowUserToAddRows = false;
            this.dataBCI.AllowUserToDeleteRows = false;
            this.dataBCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBCI.Location = new System.Drawing.Point(629, 47);
            this.dataBCI.Name = "dataBCI";
            this.dataBCI.ReadOnly = true;
            this.dataBCI.Size = new System.Drawing.Size(547, 248);
            this.dataBCI.TabIndex = 6;
            // 
            // btnSeguro
            // 
            this.btnSeguro.Location = new System.Drawing.Point(629, 12);
            this.btnSeguro.Name = "btnSeguro";
            this.btnSeguro.Size = new System.Drawing.Size(552, 29);
            this.btnSeguro.TabIndex = 7;
            this.btnSeguro.Text = "Adjuntar Excel del Seguro [PLANILLA BCI]";
            this.btnSeguro.UseVisualStyleBackColor = true;
            this.btnSeguro.Click += new System.EventHandler(this.btnSeguro_Click);
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(413, 301);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(376, 23);
            this.btnCompara.TabIndex = 8;
            this.btnCompara.Text = "Compara datos";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnAgregarAseguro
            // 
            this.btnAgregarAseguro.Location = new System.Drawing.Point(12, 618);
            this.btnAgregarAseguro.Name = "btnAgregarAseguro";
            this.btnAgregarAseguro.Size = new System.Drawing.Size(547, 23);
            this.btnAgregarAseguro.TabIndex = 12;
            this.btnAgregarAseguro.Text = "Exportar A Excel [Personas para agregar al seguro]";
            this.btnAgregarAseguro.UseVisualStyleBackColor = true;
            this.btnAgregarAseguro.Click += new System.EventHandler(this.btnAgregarAseguro_Click);
            // 
            // btnSacarDelSeguro
            // 
            this.btnSacarDelSeguro.Location = new System.Drawing.Point(624, 618);
            this.btnSacarDelSeguro.Name = "btnSacarDelSeguro";
            this.btnSacarDelSeguro.Size = new System.Drawing.Size(552, 23);
            this.btnSacarDelSeguro.TabIndex = 13;
            this.btnSacarDelSeguro.Text = "Exportar a Excel [Peronas para sacar del seguro]";
            this.btnSacarDelSeguro.UseVisualStyleBackColor = true;
            this.btnSacarDelSeguro.Click += new System.EventHandler(this.btnSacarDelSeguro_Click);
            // 
            // dataAgregarAseguro
            // 
            this.dataAgregarAseguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAgregarAseguro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUT_TITULAR,
            this.DV_TITULAR,
            this.NOMBRE_TITULAR,
            this.AP_TITULAR,
            this.AM_TITULAR,
            this.NOMBRECARGA,
            this.APELLIDOPATERNO,
            this.APELLIDOMATERNO,
            this.RUTCARGA,
            this.DVCARGA,
            this.FECHAINICIO,
            this.FECHATERMINO,
            this.FECHANACIMIENTO,
            this.ESTADO,
            this.TIPOSOCIO});
            this.dataAgregarAseguro.Location = new System.Drawing.Point(12, 351);
            this.dataAgregarAseguro.Name = "dataAgregarAseguro";
            this.dataAgregarAseguro.Size = new System.Drawing.Size(547, 248);
            this.dataAgregarAseguro.TabIndex = 14;
            // 
            // RUT_TITULAR
            // 
            this.RUT_TITULAR.HeaderText = "RUT_TITULAR";
            this.RUT_TITULAR.Name = "RUT_TITULAR";
            // 
            // DV_TITULAR
            // 
            this.DV_TITULAR.HeaderText = "DV_TITULAR";
            this.DV_TITULAR.Name = "DV_TITULAR";
            // 
            // NOMBRE_TITULAR
            // 
            this.NOMBRE_TITULAR.HeaderText = "NOMBRE_TITULAR";
            this.NOMBRE_TITULAR.Name = "NOMBRE_TITULAR";
            // 
            // AP_TITULAR
            // 
            this.AP_TITULAR.HeaderText = "AP_TITULAR";
            this.AP_TITULAR.Name = "AP_TITULAR";
            // 
            // AM_TITULAR
            // 
            this.AM_TITULAR.HeaderText = "AM_TITULAR";
            this.AM_TITULAR.Name = "AM_TITULAR";
            // 
            // NOMBRECARGA
            // 
            this.NOMBRECARGA.HeaderText = "NOMBRECARGA";
            this.NOMBRECARGA.Name = "NOMBRECARGA";
            // 
            // APELLIDOPATERNO
            // 
            this.APELLIDOPATERNO.HeaderText = "APELLIDOPATERNO";
            this.APELLIDOPATERNO.Name = "APELLIDOPATERNO";
            // 
            // APELLIDOMATERNO
            // 
            this.APELLIDOMATERNO.HeaderText = "APELLIDOMATERNO";
            this.APELLIDOMATERNO.Name = "APELLIDOMATERNO";
            // 
            // RUTCARGA
            // 
            this.RUTCARGA.HeaderText = "RUTCARGA";
            this.RUTCARGA.Name = "RUTCARGA";
            // 
            // DVCARGA
            // 
            this.DVCARGA.HeaderText = "DVCARGA";
            this.DVCARGA.Name = "DVCARGA";
            // 
            // FECHAINICIO
            // 
            this.FECHAINICIO.HeaderText = "FECHAINICIO";
            this.FECHAINICIO.Name = "FECHAINICIO";
            // 
            // FECHATERMINO
            // 
            this.FECHATERMINO.HeaderText = "FECHATERMINO";
            this.FECHATERMINO.Name = "FECHATERMINO";
            // 
            // FECHANACIMIENTO
            // 
            this.FECHANACIMIENTO.HeaderText = "FECHANACIMIENTO";
            this.FECHANACIMIENTO.Name = "FECHANACIMIENTO";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // TIPOSOCIO
            // 
            this.TIPOSOCIO.HeaderText = "TIPOSOCIO";
            this.TIPOSOCIO.Name = "TIPOSOCIO";
            // 
            // dataSacarDelSeguro
            // 
            this.dataSacarDelSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSacarDelSeguro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUT_TITULARDG4,
            this.DV_TITULARDG4,
            this.NOMBRE_TITULARDG4,
            this.AP_TITULARDG4,
            this.AM_TITULARDG4,
            this.NOMBRESDG4,
            this.APELLIDOPATERNODG4,
            this.APELLIDOMATERNODG4,
            this.RUTCARGADG4,
            this.DVCARGADG4,
            this.FECHAINICIODG4,
            this.FECHATERMINODG4,
            this.FECHANACIMIENTODG4,
            this.ESTADODG4,
            this.TIPOSOCIODG4});
            this.dataSacarDelSeguro.Location = new System.Drawing.Point(629, 351);
            this.dataSacarDelSeguro.Name = "dataSacarDelSeguro";
            this.dataSacarDelSeguro.Size = new System.Drawing.Size(547, 248);
            this.dataSacarDelSeguro.TabIndex = 15;
            // 
            // RUT_TITULARDG4
            // 
            this.RUT_TITULARDG4.HeaderText = "RUT_TITULAR";
            this.RUT_TITULARDG4.Name = "RUT_TITULARDG4";
            // 
            // DV_TITULARDG4
            // 
            this.DV_TITULARDG4.HeaderText = "DV_TITULAR";
            this.DV_TITULARDG4.Name = "DV_TITULARDG4";
            // 
            // NOMBRE_TITULARDG4
            // 
            this.NOMBRE_TITULARDG4.HeaderText = "NOMBRE_TITULAR";
            this.NOMBRE_TITULARDG4.Name = "NOMBRE_TITULARDG4";
            // 
            // AP_TITULARDG4
            // 
            this.AP_TITULARDG4.HeaderText = "AP_TITULAR";
            this.AP_TITULARDG4.Name = "AP_TITULARDG4";
            // 
            // AM_TITULARDG4
            // 
            this.AM_TITULARDG4.HeaderText = "AM_TITULAR";
            this.AM_TITULARDG4.Name = "AM_TITULARDG4";
            // 
            // NOMBRESDG4
            // 
            this.NOMBRESDG4.HeaderText = "NOMBRES";
            this.NOMBRESDG4.Name = "NOMBRESDG4";
            // 
            // APELLIDOPATERNODG4
            // 
            this.APELLIDOPATERNODG4.HeaderText = "APELLIDOPATERNODG4";
            this.APELLIDOPATERNODG4.Name = "APELLIDOPATERNODG4";
            // 
            // APELLIDOMATERNODG4
            // 
            this.APELLIDOMATERNODG4.HeaderText = "APELLIDOMATERNODG4";
            this.APELLIDOMATERNODG4.Name = "APELLIDOMATERNODG4";
            // 
            // RUTCARGADG4
            // 
            this.RUTCARGADG4.HeaderText = "RUTCARGA";
            this.RUTCARGADG4.Name = "RUTCARGADG4";
            // 
            // DVCARGADG4
            // 
            this.DVCARGADG4.HeaderText = "DVCARGA";
            this.DVCARGADG4.Name = "DVCARGADG4";
            // 
            // FECHAINICIODG4
            // 
            this.FECHAINICIODG4.HeaderText = "FECHAINICIO";
            this.FECHAINICIODG4.Name = "FECHAINICIODG4";
            // 
            // FECHATERMINODG4
            // 
            this.FECHATERMINODG4.HeaderText = "FECHATERMINO";
            this.FECHATERMINODG4.Name = "FECHATERMINODG4";
            // 
            // FECHANACIMIENTODG4
            // 
            this.FECHANACIMIENTODG4.HeaderText = "FECHANACIMIENTO";
            this.FECHANACIMIENTODG4.Name = "FECHANACIMIENTODG4";
            // 
            // ESTADODG4
            // 
            this.ESTADODG4.HeaderText = "ESTADO";
            this.ESTADODG4.Name = "ESTADODG4";
            // 
            // TIPOSOCIODG4
            // 
            this.TIPOSOCIODG4.HeaderText = "TIPOSOCIO";
            this.TIPOSOCIODG4.Name = "TIPOSOCIODG4";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 330);
            this.progressBar1.Maximum = 25000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1163, 15);
            this.progressBar1.TabIndex = 16;
            // 
            // ComparaCargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 680);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataSacarDelSeguro);
            this.Controls.Add(this.dataAgregarAseguro);
            this.Controls.Add(this.btnSacarDelSeguro);
            this.Controls.Add(this.btnAgregarAseguro);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.btnSeguro);
            this.Controls.Add(this.dataBCI);
            this.Controls.Add(this.dataCargas);
            this.Controls.Add(this.btnSigper);
            this.Name = "ComparaCargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComparaCargas";
            this.Load += new System.EventHandler(this.ComparaCargas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgregarAseguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSacarDelSeguro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSigper;
        private System.Windows.Forms.DataGridView dataCargas;
        private System.Windows.Forms.DataGridView dataBCI;
        private System.Windows.Forms.Button btnSeguro;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnAgregarAseguro;
        private System.Windows.Forms.Button btnSacarDelSeguro;
        private System.Windows.Forms.DataGridView dataAgregarAseguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT_TITULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV_TITULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_TITULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_TITULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AM_TITULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECARGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTCARGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVCARGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHATERMINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOSOCIO;
        private System.Windows.Forms.DataGridView dataSacarDelSeguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT_TITULARDG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV_TITULARDG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_TITULARDG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_TITULARDG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AM_TITULARDG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRESDG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOPATERNODG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOMATERNODG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTCARGADG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVCARGADG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINICIODG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHATERMINODG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANACIMIENTODG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADODG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOSOCIODG4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}