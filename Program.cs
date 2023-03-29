﻿using System;

namespace Tuntikirjanpitosovellus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loggedIn = false;
            string username = "";
            string password = "";

            while (!loggedIn)
            {
                Console.WriteLine("Syötä käyttäjätunnus:");
                username = Console.ReadLine();

                Console.WriteLine("Syötä salasana:");
                password = Console.ReadLine();

                if (AuthenticateUser(username, password))
                {
                    loggedIn = true;
                }
                else
                {
                    Console.WriteLine("Väärä käyttäjätunnus tai salasana. Yritä uudelleen.");
                }
            }

            Console.WriteLine("Kirjautuminen onnistui. Voit alkaa kirjata tuntimerkintöjä.");

            while (true)
            {
                Console.WriteLine("Syötä projekti:");
                string project = Console.ReadLine();

                Console.WriteLine("Syötä kuvaus:");
                string description = Console.ReadLine();

                Console.WriteLine("Syötä tunnit:");
                double hours = double.Parse(Console.ReadLine());

                Console.WriteLine("Syötä päivämäärä (muodossa vv-kk-pp):");
                DateTime date = DateTime.Parse(Console.ReadLine());

                SaveTimeEntry(username, project, description, hours, date);

                Console.WriteLine("Tuntimerkintä tallennettu onnistuneesti.");
                Console.WriteLine();
                break;
            }
        }

        private static bool AuthenticateUser(string username, string password)
        {
            // Tarkista käyttäjätunnus ja salasana tietokannasta
            // Palauta true, jos käyttäjätunnus ja salasana ovat oikein
            // Muuten palauta false

            return true; // Tämä on väliaikainen palautusarvo, jotta esimerkkisovellus toimii
        }

        private static void SaveTimeEntry(string username, string project, string description, double hours, DateTime date)
        {
            // Tallenna tuntimerkintä tietokantaan
        }
    }
}