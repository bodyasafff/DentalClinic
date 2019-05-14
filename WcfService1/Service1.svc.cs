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
        public void AddDiagnosis(int IdClient,string name, string description)
        {
            var diagnos = _dbCtx.Diagnoses.FirstOrDefault(dig => dig.Name == name) ?? new Diagnosis() { Name = name, Description = description };
            _dbCtx.Clients.FirstOrDefault(f => f.Id == IdClient).Diagnoses.Add(diagnos);
            _dbCtx.SaveChanges();
        }
        public bool ChakLoginAddNewClient(string login)
        {
            bool Chak = false;
            Chak = _dbCtx.Clients.Any(cl => cl.Login == login);
            return Chak;
        }
        public int CountClient()
        {
                return _dbCtx.Clients.Count();
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
                var clientDb = modelClinic.Clients
                    .Include(c1 => c1.Adress)
                    .Include(c2 => c2.Adress.City)
                    .Include(c3 => c3.Adress.Country)
                    .Include(c4 => c4.Adress.Street)
                    .Include(c5 => c5.Diagnoses)
                    .Include(c6 => c6.Doctor)
                    .Include(c7 => c7.Doctor.DocStatus)
                    .SingleOrDefault(clt => clt.Login == login && clt.Password == password);
            
                operationResult = MapClient(clientDb);
               return operationResult;
            }
        }
        public bool LogIn(string login, string password)
        {
            bool chak = false;
            chak = _dbCtx.Clients.Any(f => f.Login == login && f.Password == password);
            return chak;

            //foreach (var item in _dbCtx.Clients)
            //{
            //    if (item.Login == login && item.Password == login)
            //    {
            //        chak = true;
            //        break;
            //    }
            //}
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
            modelClient.DiagnosisName = c.Diagnoses.Select(f => f.Name).ToArray();
            modelClient.DiagnosisDesc = c.Diagnoses.Select(f => f.Description).ToArray();
            modelClient.DoctorName = c.Doctor.Name;
            modelClient.DoctoorStatus = c.Doctor.DocStatus.NameStatus;
            return modelClient;
        }
        public void EditClient(ModelClient c)
        {
            var client = _dbCtx.Clients.SingleOrDefault(cli => cli.Id == c.Id);
            client.Name = c.Name;
            client.SurName = c.SurName;
            client.Phone = c.Phone;
            client.Email = c.Email;
            Adress adress = new Adress
            {
                City = _dbCtx.Cities.FirstOrDefault(cty => cty.Name == c.City) ?? new City { Name = c.City },
                Street = _dbCtx.Streets.FirstOrDefault(str => str.Name == c.Street) ?? new Street { Name = c.Street },
                Country = _dbCtx.Countries.FirstOrDefault(ctr => ctr.Name == c.Country) ?? new Country { Name = c.Country },
            };
            client.Adress = adress;
            _dbCtx.SaveChanges();
        }

        public ModelDiagnosis MapDiagosis(Diagnosis diagnosis)
        {
            ModelDiagnosis md = new ModelDiagnosis();
            md.Id = diagnosis.Id;
            md.Name = diagnosis.Name;
            md.Description = diagnosis.Description;
            return md;
        }

        public void AddDocToClient(ModelClient c)
        {
            var client = _dbCtx.Clients.FirstOrDefault(cl => cl.Id == c.Id);
            client.Doctor = _dbCtx.Doctors.FirstOrDefault(doc => doc.Name == c.DoctorName)
            ?? new Doctor{Name = c.DoctorName,
            DocStatus = _dbCtx.DocStatuses.FirstOrDefault(ds => ds.NameStatus == c.DoctoorStatus)
            ?? new DocStatus { NameStatus = c.DoctoorStatus }
            };
            _dbCtx.SaveChanges();
        }
    }
}
