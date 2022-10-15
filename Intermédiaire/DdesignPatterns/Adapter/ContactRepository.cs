using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Intermédiaire.DdesignPatterns.Adapter
{
    internal class ContactRepository : IContactRepository
    {
        public List<Contact> ConversionDepuisXml(string xml)
        {
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xml);

            XmlNodeList noeuds = doc.DocumentElement.SelectNodes("/Contacts/Contact"); //Chemin random pour récupérer le fichier xml

            List<Contact> contacts = new List<Contact>();

            foreach (XmlNode noeud in noeuds)
            {
                var c = new Contact();
                c.Id = Convert.ToInt32(noeud.Attributes["id"].Value);
                c.Nom = noeud.ChildNodes[0].InnerText;

                contacts.Add(c);
            }

            return contacts;
        }

        public string RecupererContactsXml(string cheminFichier)
        {
            string res = null;

            using var st = new StreamReader(cheminFichier);
            res = st.ReadToEnd();
            return res;
            //Ici le using prend en compte tout le code en dessous de lui et sera quand même appelé et finira son programme >> fermer st
        }
    }
}
