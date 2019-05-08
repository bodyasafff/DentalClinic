using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.ModelsToMap
{
    [DataContract]
    public class ModelDocStatus
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NameStatus { get; set; }
        [DataMember]
        public ModelDoctor[] Doctors { get; set; }
    }
}