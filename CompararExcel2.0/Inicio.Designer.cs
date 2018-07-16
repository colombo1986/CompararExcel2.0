namespace CompararExcel2._0
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComparaTitular = new System.Windows.Forms.Button();
            this.ComparaCargas = new System.Windows.Forms.Button();
            this.Consultas = new System.Windows.Forms.Button();
            this.CargarBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComparaTitular
            // 
            this.ComparaTitular.Location = new System.Drawing.Point(49, 47);
            this.ComparaTitular.Name = "ComparaTitular";
            this.ComparaTitular.Size = new System.Drawing.Size(219, 80);
            this.ComparaTitular.TabIndex = 0;
            this.ComparaTitular.Text = "Comparar Titulares";
            this.ComparaTitular.UseVisualStyleBackColor = true;
            this.ComparaTitular.Click += new System.EventHandler(this.ComparaTitular_Click);
            // 
            // ComparaCargas
            // 
            this.ComparaCargas.Location = new System.Drawing.Point(49, 153);
            this.ComparaCargas.Name = "ComparaCargas";
            this.ComparaCargas.Size = new System.Drawing.Size(219, 80);
            this.ComparaCargas.TabIndex = 1;
            this.ComparaCargas.Text = "Compara Cargas";
            this.ComparaCargas.UseVisualStyleBackColor = true;
            this.ComparaCargas.Click += new System.EventHandler(this.ComparaCargas_Click);
            // 
            // Consultas
            // 
            this.Consultas.Location = new System.Drawing.Point(49, 257);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(219, 80);
            this.Consultas.TabIndex = 2;
            this.Consultas.Text = "Consultas";
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.button1_Click);
            // 
            // CargarBase
            // 
            this.CargarBase.Location = new System.Drawing.Point(49, 362);
            this.CargarBase.Name = "CargarBase";
            this.CargarBase.Size = new System.Drawing.Size(219, 80);
            this.CargarBase.TabIndex = 3;
            this.CargarBase.Text = "Cargar Base";
            this.CargarBase.UseVisualStyleBackColor = true;
            this.CargarBase.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 468);
            this.Controls.Add(this.CargarBase);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.ComparaCargas);
            this.Controls.Add(this.ComparaTitular);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComparaTitular;
        private System.Windows.Forms.Button ComparaCargas;
        private System.Windows.Forms.Button Consultas;
        private System.Windows.Forms.Button CargarBase;
    }
}

