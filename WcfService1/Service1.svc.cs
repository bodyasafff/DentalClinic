using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Models;

namespace WcfService1
{
    [DataContract]
    public class Service1 : IService1
    {
        public void AddAdress(Adress a)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Adresses.Add(a);
            }
        }

        public bool AddClient(Client c)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Clients.Add(c);
                modelClinic.SaveChanges();
            }
            return true;
        }
        public int CountClient()
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                return modelClinic.Clients.Count();
            }
        }

        public Adress[] GetAllAdresses()
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                return modelClinic.Adresses.ToArray();
            }
        }

        public Client[] GetAllClients()
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                Client[] clients = modelClinic.Clients.ToArray();
                return clients;
            }
        }
    }
}
