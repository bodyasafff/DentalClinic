using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.ModelsToMap
{
    [DataContract]
    public class ModelDoctor
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public ModelDocStatus DocStatus { get; set; }
        [DataMember]
        public ModelClient[] Clients { get; set; }
    }
}