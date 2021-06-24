using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter4_RealEstateApp
    {
        /*
         * This will have all the run commands for the application. 
         * I want to do all my notes and projects with a single
         * main method, because it is easier for me to look over 
         * my notes and projects that way. 
         */
        public static void RunApp()
        {

        }
    }

    class Chapter4_RealEstateInvestment
    {
        int yearBuilt;
        double purchasePrice;
        string streetAddress;
        double monthlyExpense;
        double incomeFromRent;

        public int YearBuilt
        {
            get // getter for the yearBuilt
            {
                return yearBuilt;
            }
        }

        public double PurchasePrice
        {
            get
            {
                return purchasePrice; 
            }
        }

        public Chapter4_RealEstateInvestment(int yearBuilt, double purchasePrice, string streetAddress)
        {
            this.yearBuilt = yearBuilt;
            this.purchasePrice = purchasePrice;
            this.streetAddress = streetAddress;
        }
    }
}
