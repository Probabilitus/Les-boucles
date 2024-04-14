namespace Les_boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];
            
            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine("Veuillez entrer un pas de danse: ");
                string enterStep = Console.ReadLine();
                string stapeDanceUser = moves[i];
                moves.Append(stapeDanceUser);
              
                Console.WriteLine(moves);
                if (enterStep == "done") 
                {
                    break;
                }
            }
        }
    }
}
