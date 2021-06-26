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
            const double RENTAL_AMOUNT = 1000; 
            Chapter4_RealEstateInvestment invest1 = new Chapter4_RealEstateInvestment(1998, 150000, "65 Street");
            // example, set monthly expenses: insurance = 650 (per year), taxes = 1286.92, utilities = 250
            invest1.MonthlyExpense = Chapter4_PropertyApp.GetExpenses();
            invest1.IncomeFromRent = RENTAL_AMOUNT;
            Console.WriteLine("Earnings per month is {0:C}", invest1.DetermineMontlyEarnings());
        }
    }

    class Chapter4_PropertyApp
    {
        private static double insurance = 650; // cost of insurance per year
        private static double taxes = 1286.92; // amount of taxes per year
        private static double utilities = 250; // estimated month utility costs
        private string inValue; // string value for inputing data

        public static double GetExpenses()
        {
            return utilities + (12 / taxes) + (12 / insurance);
        }
    }

    class Chapter4_RealEstateInvestment
    {
        private int yearBuilt; // year the home was built 
        private double purchasePrice; // original purchase price
        private string streetAddress; // location of the home
        private double monthlyExpense; // total expenses per month
        private double incomeFromRent; // rental payment per month

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

        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }
        }

        public double MonthlyExpense
        {
            get
            {
                return monthlyExpense;
            }
            set
            {
                monthlyExpense = value;
            }
        }

        public double IncomeFromRent
        {
            get
            {
                return incomeFromRent;
            }
            set
            {
                incomeFromRent = value;
            }
        }

        /*
         * Constructor for the RealEstateInvestment object. 
         */
        public Chapter4_RealEstateInvestment(int yearBuilt, double purchasePrice, string streetAddress)
        {
            this.yearBuilt = yearBuilt;
            this.purchasePrice = purchasePrice;
            this.streetAddress = streetAddress;
        }

        public double DetermineMontlyEarnings()
        {
            return incomeFromRent - monthlyExpense;
        }

        public void RealEstateInvetment()
        {

        }
    }
}
