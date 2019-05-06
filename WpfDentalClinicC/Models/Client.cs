using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDentalClinicC.Models;

namespace WpfDentalClinicC
{
    public class Client : User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        public Adress Adress { get; set; }
        public Doctor Doctor { get; set; }
    }
}
