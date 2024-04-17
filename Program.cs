
namespace Les_boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[3];

            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine("Veuillez entrer un pas de danse: ");
                string enterStep = Console.ReadLine();
                if (enterStep == "done")
                {
                    Console.WriteLine("La danse est terminée");
                    break;
                } 
            }  
        } 
    }
}
