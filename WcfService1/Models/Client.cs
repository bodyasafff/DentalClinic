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
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        public Adress Adress { get; set; }
        public Doctor Doctor { get; set; }
    }
}