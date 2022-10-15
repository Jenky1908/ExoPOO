using Intermédiaire.DdesignPatterns.Adapter;
using Intermédiaire.DdesignPatterns.ChainOfResponsibility;
using Intermédiaire.DdesignPatterns.Command;
using Intermédiaire.DdesignPatterns.Decorator;
using Intermédiaire.DdesignPatterns.Observer.Exemple1;
using Intermédiaire.DdesignPatterns.Observer.Exemple2;
using Intermédiaire.DdesignPatterns.Proxy;
using Intermédiaire.EntitesVsObjetsValeurs;
using ContactObs = Intermédiaire.DdesignPatterns.Observer.Exemple2.Contact;


#region Entites Vs ObjetsValeurs

Entreprise e1 = new Entreprise(1, "Dawan", new Geolocation(3.3527, 48.8543));
var e2 = new Entreprise(2, "Jehann", new Geolocation(3.37, 48.8543));

int compParNom = e1.CompareTo(e2);
int compParLocation = e1.CompareToLocalisation(e2);

Console.WriteLine(compParNom + " | " + compParLocation);

List<Entreprise> entreprises = new List<Entreprise> { e1, e2 }; //Initialisation de liste

entreprises.Sort(); //Tri par nom /|\ On ne peut pas trier par localisation
entreprises.ForEach(e => Console.WriteLine(e.Nom)); //e correspond à une entreprise (c'est une expression lambda) >> ici, on affiche tous les entreprises à la console

#endregion


#region Design Patterns - Adapter

//IJsonAdapter adapter = new JsonAdapter(new ContactRepository());

//string json = adapter.RecupererContactsJson("contacts.xml");

//Console.WriteLine(json);

#endregion


#region Design Patterns - Bridge

//Les appareils et télécommandes sont indépendants, en modifiant l'un, ça ne modifie pas l'autre

#endregion


#region Design Patterns - Decorator

//Analogie à une voiture basque, et on choisit ses options >>> Poupée Russe

IVoiture voiture = new VoitureBasique(); //On a une voiture basique

voiture = new SportDecorator(voiture); //On a maintenant une voiture avec options sport
voiture.Assembler();

voiture = new LuxeDecorator(voiture); //Et enfin une voiture avec options sport ET luxe !
voiture.Assembler();

//Autre façon de faire :

IVoiture voitureSportLuxe = new SportDecorator(new LuxeDecorator(new VoitureBasique())); //(Poupée Russe)\\
voitureSportLuxe.Assembler();

#endregion


#region Design Patterns - Proxy

IMessage message = new MessageProxy(new MessageUtilisateur("Bonjour")); //Tranformation depuis MessageProxy
Console.WriteLine(message.RecupererContenu());

#endregion


#region Design Patterns - Chaine Of Responsability

MembreEquipe formateur = new Formateur("Florian", new DirPeda("Marie", new Directeur("Karl", null))); //Un peu comme les poupées russes, mais ici c'est plus une pyramide

//1er plainte

Console.WriteLine("-- Plainte 1 --");

formateur.handlePlainte(new Plainte(123, 
                    Plainte.Types.Formateur, 
                    "AHHHHHH !", 
                    Plainte.Etats.Ouvert));

//2e plainte

Console.WriteLine("-- Plainte 2 --");

formateur.handlePlainte(new Plainte(123,
                    Plainte.Types.DirPeda,
                    "OHHHHHH !",
                    Plainte.Etats.Ouvert));

//3e plainte

Console.WriteLine("-- Plainte 3 --");

formateur.handlePlainte(new Plainte(123,
                    Plainte.Types.Directeur,
                    "EHHHHHH !",
                    Plainte.Etats.Ouvert));

#endregion


#region Design Patterns - Observer

//Observateur 1 :

var produit = new Produit() //Construction par propriétés
{
    Id = 1,
    Description = "RTX 4090",
    Prix = 1300
};

produit.Attacher(new Client("Jean", "jean-bonneau@aupoivre.fr") { Id = 1}); //On peut mixer la construction par propriété et l'initialisation normal
produit.Attacher(new Client("Albert", "albert@camus.fr") { Id = 2});

produit.Prix = 150; //changement de prix >> tous les observateurs (clients) attachés vont être notifié (grâce aux propriétés de Prix dans Produit)


//Observateur 2 :

var article = new Article()
{
    Description = "Chaise",
    Prix = 40,
};

var disC1 = article.Subscribe(new ContactObs() { Nom = "John"});
var disC2 = article.Subscribe(new ContactObs() { Nom = "Jane" });

article.Prix = 30; //Le changement déclenche les notifications
                   //A la console, on ne voit 2 messages car 2 abdonnement

disC1.Dispose(); //On désinscrit le 1er observateur

article.Prix = 25; //Seul le 2e sera averti maintenant
                   //A la console, on ne voit qu'un message car 1 abdonnement

#endregion


#region Design Patterns - Command

var chef = new ChefCuisinier();
var serveur = new Serveur();

ICommander commande = new CommandeDejeuner(chef, "Burger"); //Je peux aussi mettre CommandeDiner

serveur.PrendreCommande(commande);

#endregion


#region SOLID

//1 : S >>> Single Responsability -> Une seule responsabilité pour chaque classe
//2 : O >>> Open-Close -> Ouvert pour l'extension, Fermé pour la modification
//3 : L >>> Liskov Substitution (Ex : Un véhicule peut remplacer une voiture ou un bus sans conséquence >> Hierarchie de classe, comportement en commun)
//4 : I >>> Interface Segregation -> création de plusieurs petites interfaces ciblées plutôt qu'une seule qui possède trop de déclaration
//5 : D >>> Dependence Inversion

#endregion


Console.ReadLine();









                                                                                      //||\\
                                                                                     // || \\
                                                                                    //  ||  \\
                                                                                   //   ||   \\
                                                                                  //    ||    \\
                                                                                 //     ||     \\
                                                                                //      ||      \\
                                                                               //       ||       \\
                                                                              //        ||        \\
                                                                             //         ||         \\
                                                                            //          ||          \\
                                                                           //           ||           \\
                                                                          //            ||            \\
                                                                         //             ||             \\
                                                                        //              ||              \\
                                                                       //               ||               \\
                                                                      //                ||                \\
                                                                     //                 ||                 \\
                                                                    //                  ||                  \\
                                                                   //                   ||                   \\
                                                                  //                    ||                    \\
                                                                 //                     ||                     \\
                                                                //                      ||                      \\
                                                               //                       ||                       \\
                                                              //                        ||                        \\
                                                             //                         ||                         \\
                                                            //                          ||                          \\
                                                           //                           ||                           \\
                                                          //                            ||                            \\
                                                         //                             ||                             \\
                                                        //                              ||                              \\
                                                       //                               ||                               \\
                                                      //                                ||                                \\
                                                     //                                 ||                                 \\
                                                    //                                  ||                                  \\
                                                   //                                   ||                                   \\
                                                  //                                    ||                                    \\
                                                 //                                     ||                                     \\
                                                //                                      ||                                      \\
                                               //                                       ||                                       \\
