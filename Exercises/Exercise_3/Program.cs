using System;

namespace Exercise_3
{
    class Program
    {
        public static string[,] TicTacToe = new string[4, 5] {

    { " ","A ","B ","C ","\n"},
    { "1","","","","\n"},
    { "2","","","","\n"},
    { "3","","","","\n"},
    //{ " ","","","","\n"},
    };
        public static string fielda;
        public static bool Player1;
        public static bool winCondition = false;
        public static string[] allowedInput = new string[] { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };

        static void Main(string[] args)
        {


            while (!winCondition)
            {
          
                Console.WriteLine(CreateField());
  Start:
                string setField = Convert.ToString(Console.ReadLine());
                int pos = Array.IndexOf(allowedInput, setField);
                if (pos>-1)
                {
                     Console.WriteLine(Player(setField[0], setField[1]));
                  
                }
                else if (!pos>-1)
                {
                     Console.WriteLine("screw you");
        
                    goto Start;
                }
                else if ( TicTacToe[(int)string.GetNumericValue(setField[0]),(int)string.GetNumericValue(setField[1])]) {}
            }
        }



        static string CreateField()
        {

            foreach (string a in TicTacToe)
            {
                fielda = fielda + a;
            }

            return fielda;
        }

        static string Player(char a, char b)
        {
            int a1 = 0;
            string cases = a.ToString();

            if (Player1)
            {
                switch (cases)
                {
                    case "A": a1 = 1; break;
                    case "B": a1 = 2; break;
                    case "C": a1 = 3; break;
                }

                TicTacToe[(int)Char.GetNumericValue(b), a1] = "o ";
                Player1 = false;
            }
            else
            {
                switch (cases)
                {
                    case "A": a1 = 1; break;
                    case "B": a1 = 2; break;
                    case "C": a1 = 3; break;
                }

                TicTacToe[(int)Char.GetNumericValue(b), a1] = "x ";
                Player1 = true;


            }
            return "player";
        }



    }


}
