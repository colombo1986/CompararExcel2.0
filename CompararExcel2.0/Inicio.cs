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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void ComparaTitular_Click(object sender, EventArgs e)
        {
            ComparaTitulares TitularVsBci = new ComparaTitulares();
            TitularVsBci.ShowDialog();
        }

        private void ComparaCargas_Click(object sender, EventArgs e)
        {
            ComparaCargas CargasVsBci = new ComparaCargas();
            CargasVsBci.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.ShowDialog(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarBase cargabase = new CargarBase();
            cargabase.ShowDialog(); 
        }
    }
}
