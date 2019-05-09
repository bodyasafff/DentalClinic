using AutoMapper;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using WcfService1.Models;
using WcfService1.ModelsToMap;

namespace WcfService1
{
    [DataContract]
    public class Service1 : IService1, IDisposable
    {
        private readonly ModelClinic _dbCtx = new ModelClinic();
        private bool disposed = false;
        public bool AddClient(ModelClient c,string city,string street,string country)
        {
            bool operationResult = false;
            using (ModelClinic modelClinic = new ModelClinic())
            {
                Client client = Mapper.Map<Client>(c);
                Adress adress = new Adress
                {
                    City = modelClinic.Cities.FirstOrDefault(cty => cty.Name == city) ?? new City { Name = city },
                    Street = modelClinic.Streets.FirstOrDefault(str => str.Name == street) ?? new Street { Name = street },
                    Country = modelClinic.Countries.FirstOrDefault(ctr => ctr.Name == country) ?? new Country { Name = country },
                };
                client.Adress = adress;
                try
                {
                    modelClinic.Clients.Add(client);
                    modelClinic.SaveChanges();
                    operationResult = true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return operationResult;
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
                Chak = modelClinic.Clients.Any(cl => cl.Login == login);
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
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbCtx.Dispose();
                }

                disposed = true;
            }
        }
        ~Service1()
        {
            Dispose(false);
        }
        public ModelClient GetClient(string login, string password)
        {
            using (ModelClinic modelClinic = new ModelClinic())
            {
                modelClinic.Configuration.ProxyCreationEnabled = false;
                ModelClient operationResult = null;


                // try-catch to catch if more than 1 user exists
                var clientDb = modelClinic.Clients
                    .Include(c1 => c1.Adress)
                    .Include(c2 => c2.Adress.City)
                    .Include(c3 => c3.Adress.Country)
                    .Include(c4 => c4.Adress.Street)
                    .SingleOrDefault(clt => clt.Login == login && clt.Password == password);

                operationResult = MapClient(clientDb);
               //operationResult
               return operationResult;
            }
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

        public ModelClient MapClient(Client c)
        {
            ModelClient modelClient = new ModelClient();
            modelClient.Id = c.Id;
            modelClient.Login = c.Login;
            modelClient.Password = c.Password;
            modelClient.Name = c.Name;
            modelClient.Phone = c.Phone;
            modelClient.SurName = c.SurName;
            modelClient.Street = c.Adress.Street.Name;
            modelClient.City = c.Adress.City.Name;
            modelClient.Country = c.Adress.Country.Name;
            modelClient.Email = c.Email;
            return modelClient;
        }
    }
}
