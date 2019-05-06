using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Models
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}