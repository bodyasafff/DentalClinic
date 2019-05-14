using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.ModelsToMap
{
    [DataContract]
    public class ModelClient
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string[] DiagnosisName { get; set; }
        [DataMember]
        public string[] DiagnosisDesc { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string DoctorName { get; set; }
        [DataMember]
        public string DoctoorStatus { get; set; }
    }
}