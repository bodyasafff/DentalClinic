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

        public void AddCity(City c)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Cities.Add(c);
                modelClinic.SaveChanges();
            }
        }

        public bool AddClient(Client c,string city,string street,string country)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                Adress adress = new Adress();
                bool ChakCountry = false;
                bool ChakCity = false;
                bool ChakStreet = false;
                foreach (var item in modelClinic.Cities)
                {
                    if (item.Name == city)
                    {
                        adress.City = item;
                        ChakCity = true;
                    }
                }
                foreach (var item in modelClinic.Streets)
                {
                    if (item.Name == street)
                    {
                        adress.Street = item;
                        ChakStreet = true;
                    }
                }
                foreach (var item in modelClinic.Countries)
                {
                    if (item.Name == country)
                    {
                        adress.Country = item;
                        ChakCountry = true;
                    }
                }
                if(ChakCity == false)
                {
                    City NewCity = new City();
                    NewCity.Name = city;
                    adress.City = NewCity;
                }
                if(ChakStreet == false)
                {
                    Street NewStreet = new Street();
                    NewStreet.Name = street;
                    adress.Street = NewStreet;
                }
                if(ChakCountry == false)
                {
                    Country NewCountry = new Country();
                    NewCountry.Name = country;
                    adress.Country = NewCountry;
                }
                c.Adress = adress;
                modelClinic.Clients.Add(c);
                modelClinic.SaveChanges();
            }
            return true;
        }

        public void AddDiagnosis(Client client,string name, string description)
        {
            bool ChakNameDiagnosis = false;
            Diagnosis diagnosis = new Diagnosis();
            using (ModelClinic modelClinic = new ModelClinic())
            {
                foreach (var item in modelClinic.Diagnoses)
                {
                    if(item.Name == name)
                    {
                        diagnosis = item;
                        ChakNameDiagnosis = true;
                        break;
                    }
                }
                if(ChakNameDiagnosis == false)
                {
                    diagnosis.Name = name;
                    diagnosis.Description = description;
                }
                var cli = modelClinic.Clients.SingleOrDefault(d => d.Id == client.Id);
                cli.Diagnoses.Add(diagnosis);
                modelClinic.SaveChanges();
            }
        }

        public bool ChakLoginAddNewClient(string login)
        {
            bool Chak = false;
            using (ModelClinic modelClinic = new ModelClinic())
            {
                foreach (var item in modelClinic.Clients)
                {
                    if (item.Login == login)
                    {
                        Chak = true;
                        break;
                    }
                }
            }
            return Chak;
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

        public City[] GetAllCityes()
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                return modelClinic.Cities.ToArray();
            }
        }

        public Client[] GetAllClients()
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Configuration.ProxyCreationEnabled = false;
                Client[] clients = modelClinic.Clients.ToArray();
                return clients;
            }
        }

        public Client GetClient(string login, string password)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Configuration.ProxyCreationEnabled = false;
                foreach (var item in modelClinic.Clients)
                {
                    if (item.Login == login && item.Password == password)
                        return item;
                }
            }
            return null;
        }

        public bool LogIn(string login, string password)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                bool chak = false;
                foreach (var item in modelClinic.Clients)
                {
                    if (item.Login == login && item.Password == login)
                    {
                        chak = true;
                        break;
                    }
                }
                return chak;
            }
        }
    }
}
