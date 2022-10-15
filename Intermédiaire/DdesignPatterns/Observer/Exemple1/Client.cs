using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple1
{
    internal class Client : IObservateur
    {
        public int? Id { get; set; }

        public string Nom { get; set; }

        public string Email { get; set; }

        public Client(string nom, string email)
        {
            Nom = nom;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                        Id == client.Id;
        }

        public void MettreAJouer(ISujet sujet) //Envoyer un mail au client
        {
            Produit p = (Produit)sujet;

            var corpsEmail = $"Bonjour,\nle prix du produit a été modifié : {p.Prix}";

            var m = new MailMessage("noreplay@dawan.fr",
                            Email,
                            "Changement de prix du " + p.Description,
                            corpsEmail);

            //var client = new SmtpClient(Constantes.SERVEUR_SMTP);
            //client.Credentials = CredentialCache.DefaultNetworkCredentials;
            //client.Send(m);

            Console.WriteLine(m.Body); //Juste pour montrer à la console que le prix a bien été modifié, sinon c'est le code au desus le vrai
                                       //Il y aura 2 fois le message car, il y a 2 clients (NE PAS OUBLIER L'ID)

        }
    }
}
