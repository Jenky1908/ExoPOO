using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Adapter
{
    internal class JsonAdapter : IJsonAdapter
    {
        private IContactRepository xmlRepository;

        public JsonAdapter(IContactRepository xmlRepository)
        {
            this.xmlRepository = xmlRepository;
        }

        public string RecupererContactsJson(string cheminFichier)
        {
            string xml = xmlRepository.RecupererContactsXml(cheminFichier);

            //Transformation en Json

            var contacts = xmlRepository.ConversionDepuisXml(xml);

            string resJson = null;

            DataContractJsonSerializer s = new DataContractJsonSerializer(contacts.GetType());

            using (var memStream = new MemoryStream()) //Juste pour mettre en mémoire
            {
                s.WriteObject(memStream, contacts);
                resJson = Encoding.UTF8.GetString(memStream.ToArray());
            }

            return resJson;
        }
    }
}
