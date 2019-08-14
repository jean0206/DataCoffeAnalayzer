using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Departament
    {
        private List<Municipality> municipalities = new List<Municipality>();

        public Departament() {

        }

        public List<Municipality> Municipalities { get => municipalities; set => municipalities = value; }

        public void agregar(Municipality mun) {
            Municipalities.Add(mun);
        }
    }
}
