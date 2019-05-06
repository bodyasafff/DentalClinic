using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDentalClinicC
{
    public class Adress
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Street Street { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
