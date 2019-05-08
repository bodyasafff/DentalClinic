using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.ModelsToMap
{
    [DataContract]
    public class ModelAdress
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public ModelCountry Country { get; set; }
        [DataMember]
        public ModelCity City { get; set; }
        [DataMember]
        public ModelStreet Street { get; set; }
        [DataMember]
        public ModelClient[] Clients { get; set; }
    }
}