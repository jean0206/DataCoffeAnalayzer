using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsFormsApp1
{
    public partial class Statitics : Form
    {
        private Analyzer ana;
        public Statitics()
        {
            InitializeComponent();
            chart1.Titles.Add("Crecimiento de producción de distintos departamentos");
            //addDepartament1();
            ana = new Analyzer();
            loadDepartaments();
        }

        private void Statitics_Load(object sender, EventArgs e)
        {

        }

        public void loadDepartaments() {
            ana.addDepartaments("2017");
            for (int i = 0; i < ana.Departaments.Count; i++) {
                departament1.Items.Add(ana.Departaments[i].Name);
                departament2.Items.Add(ana.Departaments[i].Name);
                departament3.Items.Add(ana.Departaments[i].Name);
            }
        }

        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            ana.addDepartaments("2016");
            Departament dep1 = ana.allMunicipalities("2016", departament1.Text);          
            chart1.Series["Departamento1"].Points.AddXY(2016, dep1.Production);
            Departament dep2 = ana.allMunicipalities("2016", departament2.Text);
            chart1.Series["Departamento2"].Points.AddXY(2016, dep2.Production);
            Departament dep3 = ana.allMunicipalities("2016", departament3.Text);
            chart1.Series["Departamento3"].Points.AddXY(2016, dep3.Production);

            ana.addDepartaments("2017");
            Departament dep4 = ana.allMunicipalities("2017", departament1.Text);          
            chart1.Series["Departamento1"].Points.AddXY(2017, dep4.Production);
            Departament dep5 = ana.allMunicipalities("2017", departament2.Text);
            chart1.Series["Departamento2"].Points.AddXY(2017, dep5.Production);
            Departament dep6 = ana.allMunicipalities("2017", departament3.Text);
            chart1.Series["Departamento3"].Points.AddXY(2017, dep6.Production);

            ana.addDepartaments("2018");
            Departament dep7 = ana.allMunicipalities("2018", departament1.Text);                       
            chart1.Series["Departamento1"].Points.AddXY(2018, dep7.Production);
            Departament dep8 = ana.allMunicipalities("2018", departament2.Text);
            chart1.Series["Departamento2"].Points.AddXY(2018, dep8.Production);
            Departament dep9 = ana.allMunicipalities("2018", departament3.Text);
            chart1.Series["Departamento3"].Points.AddXY(2018, dep9.Production);


            MessageBox.Show("Se ha completado la grafica");
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            Form f1 = new Principal();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
