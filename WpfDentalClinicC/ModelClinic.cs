namespace WpfDentalClinicC
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelClinic : DbContext
    {
        public ModelClinic()
            : base("name=ModelClinic")
        {
        }
    }
}