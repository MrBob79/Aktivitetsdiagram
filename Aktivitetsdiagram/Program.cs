using System;

namespace Aktivitetsdiagram
{
    class Diagram
    {
        private static void Main(string[] args)
        {
            int Money = 15000;      // Start kapital
            int Age;                // Åldern på användaren som lagras
            int UserAge;         // Användarens ålder
            int UserSaves;          // Hur mycket användare vill spara till
            int Diff;               // Användarens pengar - hur mycket användaren vill spara till
            bool Retire = false;    // Kontrollerar när och om användaren gått i pension




                

            Console.WriteLine("Hej och välkommen till detta Sparmålsprogram");
            Console.WriteLine("Här kommer några frågor du behöver svara på!");

            Console.WriteLine("Hur gammal är du?");
            UserAge = Console.ReadLine();

            Console.WriteLine("Skriv in ditt sparmål?");
            UserSaves = Console.ReadLIne();


            
            // Start
            // Skriv in din ålder
            // Skriv in sparmål
            // Sätt värdet i pengar till 15000
            // GÖR
            // Sätt värdet differans som sparmål minus pengar
            // OM Differensen är mindre än 10000 och ålder under 55 gör såhär
                // Sätt värdet för sparande till 2000
            // Annars OM differensen är högre än 10000
                // Sätt det för månadssparande till 5000
            // Annars OM...
                // Sätt värdet för månadssparande till 10000
            
            // Skriv ut värdet för månadssparande
            // Sätt värdet för pengar till pengar plus månadssparande
            // Öka värdet för åldern med ett (1)
            // Sant villkor så börja om
                   // OM pengar är mindre än sparmål och ålder är under 65
            // Falskt villkor så skriv ut att användaren har gått i pension och har sparat värdet i pengar

        }
    }



}
