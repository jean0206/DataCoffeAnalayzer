using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Model;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {
        Analyzer ana;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        
        
        public Map()
        {
            ana = new Analyzer();
            InitializeComponent();
            //rankingProduction("2018");
            // allDepartaments("2018");
            loadComboBox();
            inhabilitar();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            gMapCoffe.Position = new PointLatLng(4.570868, -74.2973328);
            gMapCoffe.MinZoom = 0;
            gMapCoffe.MaxZoom = 24;
            gMapCoffe.Zoom = 5;
            gMapCoffe.AutoScroll = true;
            gMapCoffe.ShowCenter = false;

        }
        public void loadComboBox() {
            yearRanking.Items.Add("2016");
            yearRanking.Items.Add("2017");
            yearRanking.Items.Add("2018");
            typeRanking.Items.Add("Ranking-produccion");
            typeRanking.Items.Add("Ranking-promedio");
            typeRanking.Items.Add("Todos");
            ana.addDepartaments("2018");
            optionBox.Items.Add("Departamentos");
            optionBox.Items.Add("Municipios");
            for (int i = 0; i < ana.Departaments.Count; i++) {
                DepartamentsBox.Items.Add(ana.Departaments[i].Name);
            }
        }

        public void rankingProduction(String year) {
            
            ana.addDepartaments(year);
            ana.majorProduction();
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            markerOverlay = new GMapOverlay("marcador");
            for(int i = 0; i < 5; i++) {
               // MessageBox.Show(""+ana.Departaments[i].Latitude+" "+ ana.Departaments[i].Length);
            marker = new GMarkerGoogle(new PointLatLng(ana.Departaments[i].Latitude,ana.Departaments[i].Length),new Bitmap("coffe.png"));
            markerOverlay.Markers.Add(marker);
               // MessageBox.Show("" + marker.Position);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = "" + (i + 1) + "-" + ana.Departaments[i].Name+"\n"+ ana.Departaments[i].Production+" (t)";
            gMapCoffe.Overlays.Add(markerOverlay);
            }
           // MessageBox.Show("" + ana.Departaments.Count);
        }
        public void rankingPerformance(String year)
        {

            ana.addDepartaments(year);
            ana.majorPerformance();
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            markerOverlay = new GMapOverlay("marcador");
            for (int i = 0; i < 5; i++)
            {
                // MessageBox.Show(""+ana.Departaments[i].Latitude+" "+ ana.Departaments[i].Length);
                marker = new GMarkerGoogle(new PointLatLng(ana.Departaments[i].Latitude, ana.Departaments[i].Length), new Bitmap("coffe.png"));
                markerOverlay.Markers.Add(marker);
               // MessageBox.Show("" + marker.Position);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = "" + (i + 1) + "-" + ana.Departaments[i].Name+"\n"+ ana.Departaments[i].Performance+" t/(ha)";
                gMapCoffe.Overlays.Add(markerOverlay);
            }
            //MessageBox.Show("" + ana.Departaments.Count);
        }
        public void allDepartaments(String year)
        {
            
            ana.addDepartaments(year);
            ana.majorProduction();
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            markerOverlay = new GMapOverlay("marcador");
            for (int i = 0; i < ana.Departaments.Count;i++) { 
            
            marker = new GMarkerGoogle(new PointLatLng(ana.Departaments[i].Latitude, ana.Departaments[i].Length), new Bitmap("coffe.png"));
            markerOverlay.Markers.Add(marker);
            gMapCoffe.Overlays.Add(markerOverlay);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = ana.Departaments[i].Name;
            
            }
        }

        public void rankingProdMunicipaties(String year, String depar) {
            Departament op = ana.allMunicipalities(year, depar);
            op.getBetterProduction();
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            markerOverlay = new GMapOverlay("marcador");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    // MessageBox.Show(""+ana.Departaments[i].Latitude+" "+ ana.Departaments[i].Length);
                    marker = new GMarkerGoogle(new PointLatLng(op.Municipalities[i].Latitude, op.Municipalities[i].Length), new Bitmap("coffe.png"));
                    markerOverlay.Markers.Add(marker);
                    // MessageBox.Show("" + marker.Position);
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTipText = "" + (i + 1)+"-"+op.Municipalities[i].Name + "\n" + op.Municipalities[i].Production + " t";
                    gMapCoffe.Overlays.Add(markerOverlay);
                }
            }
            catch (ArgumentOutOfRangeException e) {
                MessageBox.Show("" + e.Message + "\n" + "El departamento no tiene suficientes municipios para un ranking 5");
            }
        }

        public void rankingPerforMunicipaties(String year, String depar)
        {
            Departament op = ana.allMunicipalities(year, depar);
            op.getBetterPerformance();
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            markerOverlay = new GMapOverlay("marcador");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    // MessageBox.Show(""+ana.Departaments[i].Latitude+" "+ ana.Departaments[i].Length);
                    marker = new GMarkerGoogle(new PointLatLng(op.Municipalities[i].Latitude, op.Municipalities[i].Length), new Bitmap("coffe.png"));
                    markerOverlay.Markers.Add(marker);
                    // MessageBox.Show("" + marker.Position);
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTipText = ""+(i+1)+"-"+op.Municipalities[i].Name + "\n" + op.Municipalities[i].Performance + " t/ha";
                    gMapCoffe.Overlays.Add(markerOverlay);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("" + e.Message + "\n" + "El departamento no tiene suficientes municipios para un ranking 5");
            }
        }

        public void DepMunicipaties(String year, String depar)
        {
            Departament op = ana.allMunicipalities(year, depar);
            op.getBetterProduction();
            gMapCoffe.DragButton = MouseButtons.Left;
            gMapCoffe.CanDragMap = true;
            gMapCoffe.MapProvider = GMapProviders.GoogleMap;
            markerOverlay = new GMapOverlay("marcador");
            try
            {
                for (int i = 0; i < op.Municipalities.Count; i++)
                {
                    // MessageBox.Show(""+ana.Departaments[i].Latitude+" "+ ana.Departaments[i].Length);
                    marker = new GMarkerGoogle(new PointLatLng(op.Municipalities[i].Latitude, op.Municipalities[i].Length), new Bitmap("coffe.png"));
                    markerOverlay.Markers.Add(marker);
                    // MessageBox.Show("" + marker.Position);
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTipText = op.Municipalities[i].Name + "\n" + op.Municipalities[i].Production + " t";
                    gMapCoffe.Overlays.Add(markerOverlay);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("" + e.Message + "\n" + "El departamento no tiene suficientes municipios para un ranking 5");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        { 
            String c = yearRanking.Text;
            String y = typeRanking.Text;
            if (optionBox.Text.Equals("Departamentos")) {
                if (y.Equals("Ranking-produccion"))
                {
                    rankingProduction(c);
                }
                else if (y.Equals("Todos"))
                {
                    allDepartaments(c);
                }
                else if (y.Equals("Ranking-promedio")) {
                    rankingPerformance(c);
                }
            } else if (optionBox.Text.Equals("Municipios")) {
               String depar= DepartamentsBox.Text;
                if (y.Equals("Ranking-produccion"))
                {
                    rankingProdMunicipaties(c,depar);
                }
                else if (y.Equals("Todos"))
                {
                    DepMunicipaties(c, depar);
                }
                else if (y.Equals("Ranking-promedio"))
                {
                    rankingPerforMunicipaties(c, depar);
                }
            }
        }

        public void loadMarkers(String years) {

        }

        private void DepartamentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            markerOverlay.Markers.Clear();
        }

        public void inhabilitar() {
            if (optionBox.Text.Equals("Departamentos"))
            {
                DepartamentsBox.Enabled = true;
            }
        }

        private void optionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void resetZoom_Click(object sender, EventArgs e)
        {
            gMapCoffe.Zoom = 5;
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            Form f1 = new Principal();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
