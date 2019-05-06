using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DocStatus DocStatus { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}