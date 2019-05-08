using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.ModelsToMap
{
    [DataContract]
    public class ModelCity
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public ModelAdress[] Adresses { get; set; }
    }
}