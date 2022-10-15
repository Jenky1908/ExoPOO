using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple2
{
    internal class Contact : IObserver<ChangementPrixEvent>
    {
        public string Nom { get; set; }

        public void OnCompleted()
        {
            Debug.WriteLine("Terminé..."); //Ecrit sur la petite fenêtre en bas "Déboguer" (comme Console.WriteLine mais pas sur la console)
        }

        public void OnError(Exception error)
        {
            Debug.WriteLine(error.Message);
        }

        public void OnNext(ChangementPrixEvent value) //Un peu la méthode MettreAjour mais plus complet
        {
            Console.WriteLine(value.Date.ToString("dd/MM/yy") + $" : {value.MessageNotif}");
        }
    }
}
