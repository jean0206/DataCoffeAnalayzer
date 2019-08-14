using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Analyzer
    {
        private List<Departament> departaments; 
        private int[] departamentsList;
       
        public Analyzer() {
            departamentsList = new int[] { 25, 41, 44, 19, 20, 47, 50, 52, 5, 15, 17, 18, 85, 76, 54, 63, 66, 68, 73 };
           
        }

        public void addDepartaments(String year) {
            departaments = new List<Departament>();
            for (int i = 0; i < departamentsList.Length; i++) {
                int code = departamentsList[i];
                double lat = longAndLat(code)[0];
                double lon= longAndLat(code)[1];
                Departament depar = new Departament(code,null,0,0,0,0,lat,lon);
                depar.addMunicipaties(year);
                departaments.Add(depar);
            }            
        }

        public double[] longAndLat(int codigo) {
            double[] latAndLong = new double[2];
            StreamReader reader = new StreamReader("depar.txt");                    
            
            while (!reader.EndOfStream) {
                String x = reader.ReadLine();
                String[] y = x.Split(';');
                int codTem =Convert.ToInt32(y[0]);
                if (codTem==codigo) {
                    latAndLong[0] = Convert.ToDouble(y[2]);
                    latAndLong[1]= Convert.ToDouble(y[3]);
                }
            }
            return latAndLong;
        }

        public void majorProduction() {
            departaments = departaments.OrderBy(p=> p.Production).ToList();
            departaments.Reverse();
        }

        public void majorPerformance()
        {
            departaments = departaments.OrderBy(p => p.Performance).ToList();
            departaments.Reverse();
        }

        public Departament allMunicipalities(String year, String departament) {
            Departament departamen= new Departament(0,null,0,0,0,0,0,0);
            addDepartaments(year);
            
            for (int i = 0; i < departaments.Count; i++) {
                String depar = departaments[i].Name;
                if (depar.Equals(departament)) {
                    departamen = departaments[i];
                }
            }
            return departamen;
        }

        

        public List<Departament> Departaments { get => departaments; set => departaments = value; }
    }
} 
