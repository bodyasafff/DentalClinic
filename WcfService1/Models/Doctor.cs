using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Models
{
    [DataContract]
    public class Doctor
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DocStatus DocStatus { get; set; }
        [DataMember]
        public virtual ICollection<Client> Clients { get; set; }
    }
}