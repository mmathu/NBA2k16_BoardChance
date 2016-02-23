using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcMYNBA2K16
{
    //Program that calculates which card position to select... 
    //...after a game to increase chances of picking a...
    //...rare card or higher to 'turn over' the board
    //The draft board is 5x5


    //Add 2 classes - Add View

    class Program
    {
        static void Main(string[] args)
        {
           
            // 2 arrays ; 2 text files
            //Will hold the values from a text file
            //rare is the number of times the board turnsover
            string[] nonrareValues = System.IO.File.ReadAllLines("nonrarevalues.txt");
            string[] rareValues = System.IO.File.ReadAllLines("rarevalues.txt"); 
            
            //Will use the values to calculate probability
           

            //Basic GUI

            bool exitFlag = false;
            while (exitFlag == false)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1) View");
                Console.WriteLine("(2) Add");
                Console.WriteLine("(3) Exit");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":                     
                        viewCard conversion = new viewCard();
                        double[] finalPercentage = conversion.conversionStringToDouble(rareValues, nonrareValues);

                        for (int ii = 0; ii < 25; ii++)
                        {
                           
                            Console.WriteLine("{0} - {1} %",ii,finalPercentage[ii] * 100);
                        }
                        
                        break;
                    case "2":
                        addCard.addCardData(rareValues, nonrareValues);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please type in 1 , 2 or 3\n");
                        break;
                }
            }
        }

    }
}
