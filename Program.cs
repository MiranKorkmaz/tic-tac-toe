using System;

namespace tictactoe 
{
    internal class Program
    {
        // Create playfield
        static char[,] playField = {
            {'1','2','3'}, 
            {'4','5','6'},
            {'7','8','9'}
        };
        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool validInput = true;

            SetField();

            // Run code as long as the program runs
            do
            {
                if(player == 2) 
                {
                    player = 1;
                    XorO(player, input);
                }
                else if(player == 1)
                {
                    player = 2;
                    XorO(player, input);
                }
                // add method here as well
                SetField();

                // check winning condition
                #region
                char[] playerChars = { 'X', 'O' };
                
                foreach (char playerChar in playerChars)
                {
                    if(((playField[0,0] == playerChar) && (playField[0,1] == playerChar) && (playField[0,2] == player))
                    || ((playField[1,0] == playerChar) && (playField[1,1] == playerChar) && (playField[1,2] == player))
                    || ((playField[2,0] == playerChar) && (playField[2,1] == playerChar) && (playField[2,2] == player))
                    || ((playField[0,0] == playerChar) && (playField[1,0] == playerChar) && (playField[2,0] == player))
                    || ((playField[0,1] == playerChar) && (playField[1,1] == playerChar) && (playField[1,2] == player))
                    || ((playField[0,2] == playerChar) && (playField[2,1] == playerChar) && (playField[2,2] == player))
                    || ((playField[0,0] == playerChar) && (playField[1,1] == playerChar) && (playField[2,2] == player))
                    || ((playField[0,2] == playerChar) && (playField[1,1] == playerChar) && (playField[2,0] == player))) {

                        if(playerChar == 'X' || playerChar == 'O') {
                            Console.WriteLine("\nPlayer 2 has won!");
                        } else {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }
                        break;
                    }
                    
                }

                #endregion


                #region   
                do
                {
                    Console.Write("\nPlayer {0}, choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                    if ((input == 1) && playField[0,0] == '1')
                        validInput = true;
                    else if ((input == 2) && playField[0,1] == '2')
                        validInput = true;
                    else if ((input == 3) && playField[0,2] == '3')
                        validInput = true;
                    else if ((input == 4) && playField[1,0] == '4')
                        validInput = true;
                    else if ((input == 5) && playField[1,1] == '5')
                        validInput = true;
                    else if ((input == 6) && playField[1,2] == '6')
                        validInput = true;
                    else if ((input == 7) && playField[2,0] == '7')
                        validInput = true;
                    else if ((input == 8) && playField[2,1] == '8')
                        validInput = true;
                    else if ((input == 9) && playField[2,2] == '9')
                        validInput = true;
                    else {
                        Console.WriteLine("\nUse Another field");
                        validInput = false;
                    }
                } while (!validInput);
                #endregion
            } while (true);
        }

        public static void SetField() {
            Console.Clear();
            Console.WriteLine("     |      |      ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", playField[0,0],playField[0,1],playField[0,2]);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", playField[1,0],playField[1,1],playField[1,2]);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");
            Console.WriteLine(" {0}   |  {1}   |  {2}", playField[2,0],playField[2,1],playField[2,2]);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");

        }

        public static void XorO(int player, int input)
        {
            char sign = ' ';

            if (player == 1)
                sign = 'X';
            else if (player == 2)
                sign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = sign; break;
                case 2: playField[0, 1] = sign; break;
                case 3: playField[0, 2] = sign; break;
                case 4: playField[1, 0] = sign; break;
                case 5: playField[1, 1] = sign; break;
                case 6: playField[1, 2] = sign; break;
                case 7: playField[2, 0] = sign; break;
                case 8: playField[2, 1] = sign; break;
                case 9: playField[2, 2] = sign; break;
            }
        }
    }
}