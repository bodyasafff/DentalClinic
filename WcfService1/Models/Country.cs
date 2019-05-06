using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }
    }
}