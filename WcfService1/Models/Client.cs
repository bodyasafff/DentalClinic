using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Models
{
    [DataContract]
    [KnownType(typeof(User))]
    public class Client : User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        [DataMember]
        public Adress Adress { get; set; }
        [DataMember]
        public Doctor Doctor { get; set; }
    }
}