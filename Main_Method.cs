using MyFirstApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            Chapter2.PracticingWritingToConsole();
            Chaper3.PracticingAddition();

            Chapter3_Carpet_Calculator bestCarpet = new Chapter3_Carpet_Calculator("best" , 27.95); 
            Chapter3_Carpet_Calculator econCarpet = new Chapter3_Carpet_Calculator("econ", 15.95);

            Chapter4.SquareExample();
        }
    }


}
