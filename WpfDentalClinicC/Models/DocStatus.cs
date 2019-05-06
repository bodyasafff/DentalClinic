using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDentalClinicC.Models
{
    public class DocStatus
    {
        public int Id { get; set; }
        public string NameStatus { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
