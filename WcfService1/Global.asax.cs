using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WcfService1.Models;
using WcfService1.ModelsToMap;

namespace WcfService1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Mapper.Initialize(ac => {
                ac.CreateMap<Adress, ModelAdress>().ReverseMap();
                ac.CreateMap<City, ModelCity>().ReverseMap();
                ac.CreateMap<Client, ModelClient>( ).ReverseMap();
                ac.CreateMap<Country, ModelCountry>().ReverseMap();
                ac.CreateMap<Diagnosis, ModelDiagnosis>().ReverseMap();
                ac.CreateMap<DocStatus, ModelDocStatus>().ReverseMap();
                ac.CreateMap<Doctor, ModelDoctor>().ReverseMap();
                ac.CreateMap<Street, ModelStreet>().ReverseMap();
            });
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}