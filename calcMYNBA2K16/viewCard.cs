using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcMYNBA2K16
{
    class viewCard
    {
        public double[] conversionStringToDouble(string[] rare, string[] notRare) // converts to double
        {
            double[] nonrareCalValues = new double[25];
            double[] rareCalValues = new double[25];

            for (int ii = 0; ii < 25; ii++)
            {
                nonrareCalValues[ii] = Convert.ToDouble(notRare[ii]);
                rareCalValues[ii] = Convert.ToDouble(rare[ii]);


            }

            double[] finalPercentage = chanceValues(rareCalValues, nonrareCalValues);



            return finalPercentage;
        }


        public double[] chanceValues(double[] rareCard, double[] nonrareCard)
        {
            double[] sumOf = new double[25]; //array used so sum up total number of cards
            double[] final = new double[25];

            for (int ii = 0; ii < 25; ii++)
            {
                sumOf[ii] = rareCard[ii] + nonrareCard[ii];
                final[ii] = rareCard[ii] / sumOf[ii];

            }

            //for (int jj = 0; jj < 25; jj++)
            //{
            //    //FINAL ANSWER is the % chance the board will be turned over

            //}

            return final;
        }
       
    }
}
