using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ClassLibraryCI;

namespace SOAPtilteamservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            
        }
        public string GetName()
        {
            Class1 s = new Class1();
            return s.GetName();
        }
    }
}
