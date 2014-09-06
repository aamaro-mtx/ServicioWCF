using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PaganaSoft.Services
{
    public class Manager : IManager
    {

        public string Greetings(string value)
        {
            return String.Format("Hola¡¡ {0}", value);
        }


        public Person CreatePerson(int id, string fname, string lname)
        {
            return new Person()
            {
                Id = id,
                FirstName = fname,
                LastName = lname
            };
        }
    }
}
