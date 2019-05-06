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
    public class Service1 : IService1
    {
        public bool AddClient(Client c)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Clients.Add(c);
                modelClinic.SaveChanges();
            }
            return true;
        }
        public void CountClient()
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Adresses.Count();
            }
        }
    }
}
