using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_29
{
    //static classes are used as contains to hold method
    //methods in these kind of classes are actions that can be performed
    static class MathMethods
    {
        //public so it can be reached in Form1.cs
        //static means that we can cal the methoe by typing MathMethod.Add
        //the method Add is a member of the class MathMethod
        //this method takes two values x ,y each of which is a type decimal
        //method returns a value back to calling code
        //this is the called code
        public static decimal Add(decimal x, decimal y)
            {
            return x + y;
            }
        public static decimal Average(decimal x, decimal y)
            {
            return (x+y)/2;
            }
    }
}
