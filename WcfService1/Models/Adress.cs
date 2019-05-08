using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Models
{
    [DataContract]
    public class Adress
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Country Country { get; set; }
        [DataMember]
        public City City { get; set; }
        [DataMember]
        public Street Street { get; set; }
        [DataMember]
        public virtual ICollection<Client> Clients { get; set; }
    }
}