using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Models
{
    [DataContract]
    public class DocStatus
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NameStatus { get; set; }
        [DataMember]
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}