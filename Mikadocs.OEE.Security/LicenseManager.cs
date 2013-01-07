using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Mikadocs.OEE.Security
{
    public class License
    {
        public bool Warn { get; set; }
        public DateTime ExpireAt { get; set; }
    }
    
    public class LicenseManager
    {
        public void RetreiveLicense(Action<License> callback)
        {
            Task task = new Task(() =>
                                     {
                                         var license = RetrieveLicenseFromServer();
                                         callback(license);
                                     });
            
            task.Start();
        }

        private static License RetrieveLicenseFromServer()
        {
            using (var webClient = new WebClient())
            {
                var license = webClient.DownloadString("http://mikadocs.net/licenses/linimatic.xml");
                using(var stringReader = new StringReader(license))
                {
                    using (var reader = new XmlTextReader(stringReader))
                    {
                        var serializer = new XmlSerializer(typeof (License));

                        return (License)serializer.Deserialize(reader);
                    }
                }
            }
        }        
    }
}
