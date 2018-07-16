namespace CompararExcel2._0
{
    partial class CargarBase
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
            this.btnTitulares = new System.Windows.Forms.Button();
            this.dataTitulares = new System.Windows.Forms.DataGridView();
            this.btnSigper = new System.Windows.Forms.Button();
            this.dataCargas = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTitulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTitulares
            // 
            this.btnTitulares.Location = new System.Drawing.Point(12, 26);
            this.btnTitulares.Name = "btnTitulares";
            this.btnTitulares.Size = new System.Drawing.Size(576, 29);
            this.btnTitulares.TabIndex = 7;
            this.btnTitulares.Text = "Adjuntar Excel de Sigper [MAESTRO SOCIOS]";
            this.btnTitulares.UseVisualStyleBackColor = true;
            this.btnTitulares.Click += new System.EventHandler(this.btnTitulares_Click);
            // 
            // dataTitulares
            // 
            this.dataTitulares.AllowUserToAddRows = false;
            this.dataTitulares.AllowUserToDeleteRows = false;
            this.dataTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTitulares.Location = new System.Drawing.Point(12, 61);
            this.dataTitulares.Name = "dataTitulares";
            this.dataTitulares.Size = new System.Drawing.Size(576, 241);
            this.dataTitulares.TabIndex = 8;
            // 
            // btnSigper
            // 
            this.btnSigper.Location = new System.Drawing.Point(12, 320);
            this.btnSigper.Name = "btnSigper";
            this.btnSigper.Size = new System.Drawing.Size(576, 29);
            this.btnSigper.TabIndex = 9;
            this.btnSigper.Text = "Adjuntar Excel de Sigper [CARGAS BIENESTAR]";
            this.btnSigper.UseVisualStyleBackColor = true;
            this.btnSigper.Click += new System.EventHandler(this.btnSigper_Click);
            // 
            // dataCargas
            // 
            this.dataCargas.AllowUserToAddRows = false;
            this.dataCargas.AllowUserToDeleteRows = false;
            this.dataCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCargas.Location = new System.Drawing.Point(12, 355);
            this.dataCargas.Name = "dataCargas";
            this.dataCargas.ReadOnly = true;
            this.dataCargas.Size = new System.Drawing.Size(576, 248);
            this.dataCargas.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 624);
            this.progressBar1.Maximum = 24000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(576, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(244, 664);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(94, 23);
            this.btnCarga.TabIndex = 12;
            this.btnCarga.Text = "Cargar base ";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // CargarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 731);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataCargas);
            this.Controls.Add(this.btnSigper);
            this.Controls.Add(this.dataTitulares);
            this.Controls.Add(this.btnTitulares);
            this.Name = "CargarBase";
            this.Text = "CargarBase";
            ((System.ComponentModel.ISupportInitialize)(this.dataTitulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCargas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitulares;
        private System.Windows.Forms.DataGridView dataTitulares;
        private System.Windows.Forms.Button btnSigper;
        private System.Windows.Forms.DataGridView dataCargas;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCarga;
    }
}