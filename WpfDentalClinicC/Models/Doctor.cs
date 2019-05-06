using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDentalClinicC.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DocStatus DocStatus { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
