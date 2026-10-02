namespace ConsoleApp_Chap5_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un prix hors taxe!");
            decimal prix = decimal.Parse(Console.ReadLine());
            
                while (prix != 0)
                { 
                prix = prix/ 1.2m;
                decimal resultat = Math.Round(prix, 2);
                System.Console.WriteLine(resultat);
                Console.WriteLine("Saisissez un prix hors taxe!");
                prix = decimal.Parse(Console.ReadLine());
            }
        }
    }
}
