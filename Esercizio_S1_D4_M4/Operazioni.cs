using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_S1_D4_M4
{
    internal class Operazioni
    {
        private string _cognome = "Aucone";
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        private string _nome = "Alessandro";

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _passwordcorretta = "Epicode";
        public string PasswordCorretta
        {
            get { return _passwordcorretta; }
            set { _passwordcorretta = value; }
        }
        private bool _accesso = false;
        public bool Accesso
        {
            get { return _accesso; }
            set { _accesso = value; }
        }

        public static DateTime OraAccesso;
        public void login()
        {
            if (_accesso == false) {
                Console.WriteLine("Cognome: ");
                string LastName = Console.ReadLine();
                Console.WriteLine("Nome: ");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Password");
                string Password = Console.ReadLine();

                if (LastName == Cognome && FirstName == Nome && Password == PasswordCorretta) {
                    Console.WriteLine($"Benvenuto/a {_nome} {_cognome}");
                    _accesso = true;
                    OraAccesso = DateTime.Now;
                    menu();

                }
                else
                {
                    Console.WriteLine("Dati errati desidera tornare al menù principale o riprovare ?");
                    Console.WriteLine("1 - Menù");
                    Console.WriteLine("2 - Riprovare login");

                    int scelta = int.Parse(Console.ReadLine());
                    if (scelta == 1)
                    {
                        menu();
                    }
                    else if (scelta == 2)
                    {
                        login();
                    }
                    else
                    {
                        Console.WriteLine("Hai selezionato una voce non valida.");
                        menu();
                    }
                }
            } 
            else 
            {
                Console.WriteLine("Attenzione sei già loggato");
                menu() ;
            }
        }


        public void logout()
        {
            if (_accesso == false)
            {
                Console.WriteLine("Errore, nessun accesso disponibile");
                menu();
            } else {
                _accesso = false;
                Console.WriteLine("Logout completato, arrivederci");
                menu();
            }
            
        }

        public void oralogin()
        {
            if(_accesso == true) 
            {
                Console.WriteLine($"Hai effettuato l'accesso alle ore {OraAccesso}");
            }
            else 
            {
                Console.WriteLine("Non hai effettuato l'accesso");
            }
            Console.WriteLine("\n" + "Premi un tasto qualsiasi per tornare al menù");
            Console.ReadLine();
            menu() ;
        }

        public void menu()
        { 
            
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Logout");
                Console.WriteLine("3 - Verifica ora e data Login");
                Console.WriteLine("4 - Lista degli Accessi");
                Console.WriteLine("5 - Esci");

                int scelta = int.Parse(Console.ReadLine());


            if (scelta == 1)
            {
                login();
            }
            else if (scelta == 2)
            {
                logout();
            }
            else if (scelta == 3)
            {
                oralogin();
            }
            else if (scelta == 4)
            {
                // verificare  gli accessi
            }
            else if (scelta == 5)
            {
                Console.WriteLine("Arrivederci");
                Console.ReadLine() ;
            }
            else
            {
                Console.WriteLine("Hai selezionato una voce non valida.");
                menu();
            }
        
                
                
            }
        }
    }

