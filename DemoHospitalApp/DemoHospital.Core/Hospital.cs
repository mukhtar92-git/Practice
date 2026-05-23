using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHospital.Core
{
    public class Hospital
    {
        private List<Patient> patients;
        public string Name { get; set; }

        public Hospital() {
            patients = new List<Patient>();        
        }
    }
}
