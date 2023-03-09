using System;
using System.Security.Cryptography.X509Certificates;

namespace LeClassiCGM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(
              "Bruno",
              "Ferreira",
              40,
              92,
              29,
              false,
              0,
              false,
              true,
              900000M
              );

            person1.getValues();

            //interpolazione

        }


        internal class Person
        {
            static int counter = 0;
            string _name;
            string _surname;
            int _age;
            bool _isAdult;
            decimal _bonus;
            decimal _pilComune;
            int _maturita;
            int _universita;
            bool _fedinaPenale;
            int _figli;
            bool _militare;
            bool _debiti;
            int _punteggio;
            const int indeceBonus = 35;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public string FullName { get { return _name + " " + _surname; } }
            public bool IsAdult { get { return _isAdult; } }
            // public int Premio { get { return _premio; } }

            public Person(

                string Name,
                string Surname,
                int Age,
                int Maturita,
                int Universita,
                bool FedinaPenale,
                int Figli,
                bool Militare,
                bool Debiti,
                decimal PilComune
                ) // firma del costruttore
            {
                _name = Name;
                _surname = Surname;


                // variabili per il BONUS 
                _age = Age;
                _maturita = Maturita;
                _universita = Universita;
                _fedinaPenale = FedinaPenale;
                _figli = Figli;
                _militare = Militare;
                _debiti = Debiti;
                _pilComune = PilComune;


                counter++;
                setIsAdult();
                CalcolaBonus(); // calcola bonus
            }
            public void getValues()
            {
                //Console.WriteLine(
                //$"Nome:{_name}\n " +
                //$"Cognome:{_surname}\n" +
                //$"Age:{_age}" +
                //$"Maturita:{_maturita}" +
                //$"FedinaPenale:{_fedinaPenale}" +
                //$"Debiti: {_debiti}"
                //);
                Console.WriteLine($"Nome:{_name}");
                Console.WriteLine($"Cognome:{_surname}");
                Console.WriteLine($"Age:{_age}");
                Console.WriteLine($"Maturita:{_maturita}");
                Console.WriteLine($"Debiti:{_debiti}");

                // da implementare ad una funzione a parte
                
                {

                    if (_bonus == 1000) Console.WriteLine($"complimenti hai raggiunto : {_punteggio} punto e veranno accreditati sul tuo conto: {_bonus} euro)");
                    else Console.WriteLine($"mi spiace: {_punteggio} non hai i riquisitio per il : {_bonus} ");
                }
            }
            public int getCounter()
            {
                return counter;
            }

            private void setIsAdult()
            {
                if (_age > 18)
                {
                    _isAdult = true;
                }
                else
                {
                    _isAdult = false;
                }
            }

            private void CalcolaBonus()
            {


                /*
                   Calcolo per il bonus cittadino
                */


                if (_maturita >= 90)
                {
                    _punteggio += 7;
                }
                if (_age >= 18 && _age <= 28)
                {
                    _punteggio += 6;
                }
                if (_debiti)
                {
                    _punteggio += 5;
                }
                if (_militare)
                {
                    _punteggio += 5;
                }
                if (_fedinaPenale == false)
                {
                    _punteggio += 5;
                }
                if (_figli >= 2)
                {
                    _punteggio += 8;
                }
                if (_pilComune < 1000000M)
                {
                    _punteggio += 8;
                }
                if (_universita >= 28)
                {
                    _punteggio += 6;
                }
                if (_punteggio >= indeceBonus && _age >= 18)
                {
                    _bonus = 1000;
                }
                else
                { _bonus = 0; }

                
    
        }
        }
    }
}
