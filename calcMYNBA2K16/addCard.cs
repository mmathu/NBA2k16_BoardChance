using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcMYNBA2K16
{
    class addCard
    {
        public static void addCardData(string[] rareCard, string[] nonRareCard)
        {
           
            bool rare = false;
            bool exit = false;

            addCard temp = new addCard(); //creates new object

            string cardPosition = temp.boardPosition(exit)  ; //determines board position
            exit = false; //Allows loop in rareOrNot to operate
            rare = temp.rareOrNot(exit, rare);
            writeValues(cardPosition, rare, rareCard, nonRareCard);
        }

        string boardPosition(bool exitLoop)
        {
            string position = "0";
            //ask for pos
            int boardAnswer = 0;

            while (exitLoop == false)
            {
                Console.WriteLine("Position on the board (0 - 24)");
                boardAnswer = Int32.Parse(Console.ReadLine());
                if (boardAnswer >= 0 && boardAnswer <= 24)
                {
                    //Error handling
                    position = Convert.ToString(boardAnswer);
                    exitLoop = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number from 0 - 24");

                }
            }

            return position;
        }


        bool rareOrNot(bool exitValue, bool rare)
        {
            while (exitValue == false)
            {

                Console.WriteLine("Did the card turn over the table? (Y) (N)");
                string cardAnswer = Console.ReadLine();
                if (cardAnswer == "Y")
                {
                    rare = true;
                    exitValue = true;
                    
                }
                else if (cardAnswer == "N")
                {
                    rare = false;
                    exitValue = true;
                }
                else
                {
                    Console.WriteLine("Please enter 'Y' or 'N'");
                }
            }
            return rare;
        }


        static void writeValues(string cardPosition, bool rare, string[]rareCard, string[] nonRareCard)
        {
            int valueIncreased = 0; //Value to be increased by one
            int ii = Int32.Parse(cardPosition);
            switch (rare)
            {
                case true:
                    valueIncreased = Int32.Parse(rareCard[ii]) + 1;
                    rareCard[ii] = Convert.ToString(valueIncreased);
                    //writeData(rareCard);
                    System.IO.File.WriteAllLines(@"rarevalues.txt", rareCard);
                    Console.WriteLine("Rare card has been added");
                    break;

                case false:
                    valueIncreased = Int32.Parse(nonRareCard[ii]) + 1;
                    nonRareCard[ii] = Convert.ToString(valueIncreased);
                    //writeData(nonRareCard);
                    System.IO.File.WriteAllLines(@"nonrarevalues.txt", nonRareCard);
                    Console.WriteLine("Non rare card has been added");
                    break;
                default:
                    break;
            }



        }

    }

}
