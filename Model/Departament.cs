using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Departament
    {
        private int code;
        private String name;
        private int year;
        private double production;
        private double performance;
        private double harvestArea;
        private double latitude;
        private double length;
        private List<Municipality> municipalities= new List<Municipality>();

        public Departament(int code, string name, int year, double production, double performance, double harvestArea, double latitude, double length)
        {
            this.Code = code;
            this.Name = name;
            this.Year = year;
            this.Production = production;
            this.Performance = performance;
            this.HarvestArea = harvestArea;
            this.Latitude = latitude;
            this.Length = length;
        }

        public void addMunicipaties(String year)
        {
            String x = "";

            StreamReader reader = new StreamReader("cafe1.csv");
            x = reader.ReadLine();
            Municipality unicipality = null;
            while (!reader.EndOfStream)
            {
                String[] y;                
                x = reader.ReadLine();
                y = x.Split(';');
               
                    if (y[10].Equals(year)&&y[0].Equals(""+code))
                {
                    try
                    {

                        int codes = Convert.ToInt32(y[2]);
                        String names = y[3];
                        int years = Convert.ToInt32(y[10]);
                        double productions = Convert.ToDouble(y[13]);
                        double performances = Convert.ToDouble(y[14]);
                        double harvestAres = Convert.ToDouble(y[12]);
                        double latitudes = getValueLatAndLong(codes)[0];
                        double lengths =  getValueLatAndLong(codes)[1];
                        unicipality = new Municipality(codes, names, years, productions, performances, harvestAres, latitudes, lengths);
                        municipalities.Add(unicipality);
                        name = y[1];
                        production += productions;
                        harvestArea += harvestAres;
                        performance += performances;
                        this.year = years;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }
               
            }
            reader.Close();
            performance = performance / municipalities.Count;
        }
        public double[] getValueLatAndLong(int id)
        {
            
            double[] latAndLong = new double[2];
            StreamReader reader = new StreamReader("municipios2.txt");
            string temporal1 = "";
            while (!reader.EndOfStream) {
                temporal1 = reader.ReadLine();
                String[] temporal2 = temporal1.Split(';');
                try {
                    int cod = Convert.ToInt32(temporal2[0]);
                    if (cod == id)
                    {
                        latAndLong[0] = Convert.ToDouble(temporal2[4]);
                        latAndLong[1] = Convert.ToDouble(temporal2[5]);
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
                
               
            }
            reader.Close();
            return latAndLong;
        }

        public void getBetterProduction() {
            municipalities = municipalities.OrderBy(p => p.Production).ToList();
            municipalities.Reverse();
        }

        public void getBetterPerformance()
        {
            municipalities = municipalities.OrderBy(p => p.Performance).ToList();
            municipalities.Reverse();
        }



        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public double Production { get => production; set => production = value; }
        public double Performance { get => performance; set => performance = value; }
        public double HarvestArea { get => harvestArea; set => harvestArea = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Length { get => length; set => length = value; }
        public List<Municipality> Municipalities { get => municipalities; set => municipalities = value; }
    }  
}
