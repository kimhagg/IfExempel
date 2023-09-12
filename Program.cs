namespace IfExempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rymdSkepp = "";
            if (PasswordCheck() && AgeCheck()) {
                rymdSkepp = ValjSkepp();
                Console.WriteLine("Du valde " + rymdSkepp + "!");
            }
        }

        private static string ValjSkepp()
        {
            byte skeppsVal = 0;
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
            return "Något gick fel, starta om programmet för att välja skepp.";
        }

        static bool PasswordCheck()
        {
            string korrektLosenord = "MayThe4rth";

            Console.Write("Skriv in ditt Lösenord: ");
            string anvandarensLosenord = Console.ReadLine();

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
            byte minAlder = 18;

            Console.Write("Skriv in din ålder: ");
            byte anvandaresAlder = Convert.ToByte(Console.ReadLine());

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