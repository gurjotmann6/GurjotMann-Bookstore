using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gurjot Mann
//Cis 3309-Section 1
//Frank Friedman
//Lab Bookstore Project

namespace GurjotMann_Bookstore.classes
{
    class Globals
    {
        // NOTE:
        //       Static methods of a class may be called without instantiating the class
        //              They called from the class itself
        //       Static objects or variables may be accessed without creating an instance of the class
        //              that contains them
        //       When you declare a class as static, all its members are automatically static

        // Application classes -- BookStore is accessible throughout all code without passing it as an argument
        public static BookStoreClass BookStore = new BookStoreClass();
    }
}
