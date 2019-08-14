using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Analyzer
    {
        private Departament depar;
        public Analyzer(){
            depar = new Departament();

        }

        public String agregar() {
            Municipality mun = new Municipality(2,"juan",20,20,20,20,20,20);
            depar.agregar(mun);
            String x=depar.Municipalities[0].Name;
            return x;
        }

    }
}
