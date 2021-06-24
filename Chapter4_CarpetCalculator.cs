using System;
using System.Collections.Generic;
using System.Text;

/*
 * This method is taken from the textbook on pg 179
 * It is the application of the material covered from
 * chapter 4 of the text book. 
 */


namespace C_sharp_Programming
{
    class Chapter4_CarpetCalculator
    {
        private double pricePerSqYard;
        private double noOfSquareYards;

        /*
         * This is the variable property for pricePerSqYard. 
         * Price is how this variable will be referred to. 
         * For example, carpetCalc.Price = 4; 
         */
        public double Price
        {
            get
            {
                return pricePerSqYard;
            }
            set
            {
                pricePerSqYard = value;
            }
        }

        /*
         * This is a constructor the object. (2 params) 
         */
        public Chapter4_CarpetCalculator(double amountNeeded, double price)
        {
            noOfSquareYards = amountNeeded;
            pricePerSqYard = price;
        }

        /*
         * This is a constructor for the object. (1 param)
         */
        public Chapter4_CarpetCalculator(double price)
        {
            pricePerSqYard = price;
        }

        public double DetermineTotalCost()
        {
            return (pricePerSqYard * noOfSquareYards);
        }

        /* 
         * Overloaded mutator method, this method is interesting
         * because it takes arguments and re-assigns the noOfSquareYards
         * based on those arguments. 
         */
        public void SetNoOfSquareYards(double length, double width)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            noOfSquareYards = length * width / SQ_FT_PER_SQ_YARD;
        }

        // Standard accessor method
        public double GetNoOfSquareYards()
        {
            return noOfSquareYards;
        }

        public override string ToString()
        {
            return "Price per square yard: " + pricePerSqYard.ToString("C") +
                   "\nTotal square yards: " + noOfSquareYards.ToString("F1") +
                   "\nTotal price: " + DetermineTotalCost().ToString("C");
        }
    }
}
