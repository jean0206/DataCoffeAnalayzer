using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Municipality
    {
        private int code;
        private String name;
        private int year;
        private double production;
        private double performance;
        private double harvestArea;
        private double latitude;
        private double length;

        public Municipality(int code, string name, int year, double production, double performance, double harvestArea, double latitude, double length)
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

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public double Production { get => production; set => production = value; }
        public double Performance { get => performance; set => performance = value; }
        public double HarvestArea { get => harvestArea; set => harvestArea = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Length { get => length; set => length = value; }
    }
}
