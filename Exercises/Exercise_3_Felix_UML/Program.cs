using System;

namespace Exercise_2_Felix_UML
{
    class Program
    {

        public static string [] ticTacToe = new string [16]{
                " ","-","-","-\n",
                "|","","","\n",
                "|","","","\n",
                "|","","","\n",


        }; 
     


     public static string matchField;
        static void Main(string[] args)
        {
          
            
            Console.WriteLine(CreateField());
            Console.WriteLine("Player 1 your turn:");
         string  playerInput = Convert.ToString(Console.ReadLine());
        }



          static string CreateField()
        {

            foreach (string a in ticTacToe)
            {
                matchField = matchField + a;
            }

            return matchField;
        }
    }

    
}
