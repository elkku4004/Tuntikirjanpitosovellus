using System;

namespace Tuntikirjanpitosovellus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loggedIn = false;
            string username = "";
            string password = "";
            string sidottu = "";
            string sitoutumaton = "";
            string sairasloma = "";
            int sairaslomamäärä = "";

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

                Console.WriteLine("Syötä päivämäärä (muodossa pp-kk-vv):");
                DateTime date = DateTime.Parse(Console.ReadLine());

                SaveTimeEntry(username, project, description, hours, date);

                Console.WriteLine("Tuntimerkintä tallennettu onnistuneesti.");
                Console.WriteLine();
            }
        }

        private static bool AuthenticateUser(string username, string password)
        {
            // Tarkista käyttäjätunnus ja salasana tietokannasta
            // Palauta true, jos käyttäjätunnus ja salasana ovat oikein
            // Muuten palauta false

            return true; // Tämä on väliaikainen palautusarvo, jotta esimerkkisovellus toimii

            {
                else if
                    return false;
            }
        }

        private static void SaveTimeEntry(string username, string project, string description, double hours, DateTime date)
        {
            // Tallenna tuntimerkintä tietokantaan
                    // Yhdistä tietokantaan
    string connectionString = "CONNECTION_STRING_TAHA";
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();

        // Luo SQL req tallentaaksesi tuntimerkintä tietokantaan
        string query = "INSERT INTO TimeEntries (Username, Project, Description, Hours, Date) VALUES (@Username, @Project, @Description, @Hours, @Date)";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            // Aseta SQL parametrit
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Project", project);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Hours", hours);
            command.Parameters.AddWithValue("@Date", date);

            // Suorita SQL
            command.ExecuteNonQuery();
        }
    }
        }
    }
}
