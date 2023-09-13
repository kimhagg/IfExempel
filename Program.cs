namespace IfExempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rymdSkepp = ""; //initialize spaceship name variable

            //Check password and age before letting user select spaceship
            if (PasswordCheck() && AgeCheck()) {
                rymdSkepp = ValjSkepp();
                Console.WriteLine("Du valde " + rymdSkepp + "!");
            }
            JediTraning();
        }

        private static void JediTraning()
        {
            //Take information from user to check how their test went
            Console.Write("Vilken svårighetsgrad tränade du på? (Lätt, Medel, Svår) ");
            string svarighetsGrad = Console.ReadLine();

            Console.Write("Hur lång tid tog det att avsluta träningen i sekunder? ");
            int tid = Convert.ToInt32(Console.ReadLine());

            //Based on user input, test how they did and reply back in console.
            if (svarighetsGrad == "Lätt" && tid <= 10)
            {
                Console.WriteLine("Du är en lovande Padawan!");
            } 
            else if (svarighetsGrad == "Medel" && tid <= 20)
            {
                Console.WriteLine("Du är på rätt väg, unga Jedi!");
            } 
            else if (svarighetsGrad == "Svår" && tid <= 30)
            {
                Console.WriteLine("Mästerlig prestation, Jedi-mästare!");
            }
            else {
                Console.WriteLine("Försök igen, kraften är med dig.");
            }
         }

        private static string ValjSkepp()
        {
            byte skeppsVal = 0; //initialize spaceship selection

            //while loop that selects the ship and complains if you try to mess around with incorrect selections
            while (skeppsVal == 0){ 
                Console.Write("Vilket skepp vill du välja? (1, 2 eller 3): ");
                skeppsVal = Convert.ToByte(Console.ReadLine());

                if (skeppsVal == 1)
                {
                    return "U.S.S Enterprise";
                }
                else if (skeppsVal == 2)
                {
                    return "Klingon Bird of Prey";
                }
                else if (skeppsVal == 3)
                {
                    return "Romulan Warbird";
                }
                else {
                    Console.WriteLine("Ogiltigt val. Välj 1, 2 eller 3.");
                    skeppsVal = 0;
                }
            }

            //returns error message if while loop somehow doesn't start
            return "Något gick fel, starta om programmet för att välja skepp.";
        }

        static bool PasswordCheck()
        {
            string korrektLosenord = "MayThe4rth"; //The worst secured password in the universe


            //ask user for password entry then save in variable
            Console.Write("Skriv in ditt Lösenord: ");
            string anvandarensLosenord = Console.ReadLine();

            //check if user entered right password or not
            if (anvandarensLosenord == korrektLosenord)
            {
                Console.WriteLine("Välkommen, Jedi-mästare!");
                return true;
            }
            else
            {
                Console.WriteLine("Fel lösenord. Försök igen");
                return false;
            }
        }

        static bool AgeCheck()
        {
            byte minAlder = 18; //minimum age

            //Get users age from input
            Console.Write("Skriv in din ålder: ");
            byte anvandaresAlder = Convert.ToByte(Console.ReadLine());

            //Check if users age is old enough to drive spaceships
            if (anvandaresAlder >= minAlder)
            {
                Console.WriteLine("Du är gammal nog att köra rymdskepp!");
                return true;
            }
            else { 
                Console.WriteLine("Du är för ung för att köra rymdskepp.");
                return false;
            }
        }
    }
}