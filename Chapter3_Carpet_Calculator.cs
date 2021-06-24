﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter3_Carpet_Calculator
    {

        /*
         * This is a carpet price calculator. pg 118
         * 
         * Room dimensions: length = 12 ft 2 inches (146 inches) 
         *                  width  = 14 ft 7 inches (175 inches)
         * Carpet types: $27.95 per square yard (best)
         *               $15.95 per square yard (economy)
         */

        private int roomLengthFeet = 12;
        private int roomLengthInches = 2;
        private int roomWidthFeet = 14;
        private int roomWidthInches = 7;
        private double roomLength;
        private double roomWidth;
        private double carpetPrice;
        private string name;
        private const double FT_TO_INCHES = 12;
        private const double SQFT_TO_SQYRD = 9;

        /*
         * The variable property, by convention, should be spelled similar to the instance variable,
         * with the expection of it being capital case. Example, so to define a numberOfDouble property 
         * it would be NumberofDouble. 
         */
        public string Name // This is called a property, pg 173
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public double GetRoomLength() //  Example 4-20, pg 172
        {
            /*
             * This is a standard accessor/getter method. It simply returns the private double roomLength, 
             * class variable. This functions the same as Java. 
             */
            return roomLength;
        }

        public void SetRoomLength(double setLength) // Example 4-21, pg 172
        {
            /*
             * This is a standard mutator/setter method. It simply sets the class variable roomLength
             * to the method parameter variable. Pretty much exactly like Java. 
             * A mutator method can also be overloaded. There can be several mutator methods that are
             * of the same method name, but have different parameters. 
             */
            this.roomLength = setLength;
        }

        public Chapter3_Carpet_Calculator(string name, double carpetPrice)
        {
            this.name = name;
            roomLength = roomLengthFeet * FT_TO_INCHES + roomLengthInches;
            roomWidth = roomWidthFeet * FT_TO_INCHES + roomWidthInches;
            this.carpetPrice = DeterminePrice(carpetPrice);
            Console.WriteLine("Room length (inches): " + roomLength + " Room width (inches): " + roomWidth);
            // Console.WriteLine(DetermineSquareFeet());
            // Console.WriteLine(DetermineSquareYards());
            Console.WriteLine("The price for " + this.name + " is {0:c}.", this.carpetPrice);
        }
        public double DetermineSquareFeet()
        {
            return (roomLength / FT_TO_INCHES) * (roomWidth / FT_TO_INCHES); 
        }
        public double DetermineSquareYards()
        {
            return DetermineSquareFeet() / SQFT_TO_SQYRD;
        }
        public double DeterminePrice(double price)
        {
            return price * DetermineSquareYards();
        }
    }
}
