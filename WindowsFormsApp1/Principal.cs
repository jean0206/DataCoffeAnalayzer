using System;
using System.Windows.Forms;
using Model;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e) {

            cargar();
        }

        public void cargar() {
          
        }

        private void Mapa_Click(object sender, EventArgs e)
        {
            Form map = new Map();
            this.Hide();
            map.ShowDialog();
            this.Close();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Form f1 = new Statitics();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
