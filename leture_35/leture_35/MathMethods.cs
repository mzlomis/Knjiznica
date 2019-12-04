using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leture_35
{
    //class functions as a container for storing methods relating to mathematics
    static class MathMethods
    {
        //public so the method can be accesed outside
        //static so the mehtod can be called by name Method.Summarize
        //void means no value is returned
        //name of method is summarize
        //in generat,through paramethers values are passed into the body of a method
        //the first parameter is an array of decimal data values so we have something to work on
        //out decimal max is used to set the value of the variable that represents the maximum in the array 
        //out decimal min is used to set the value of the variable that represents the minimum in the array
        //out decimal average is used to set the value of the variable that represents the average of the array
        //out decimal sum is used to set the value of the variable that represents the sum of the array
        public static void Summarize(decimal [] values, out decimal max, out decimal min, out decimal average, out decimal sum)
        {
            var list = values.ToList();//convert to list first so the may, min, average and sum can be used easily
            max = list.Max();//finds the max of list, and sets the value of the max parameter
            min = list.Min();//finds the min of the list, and sets the value of the min parameter
            average = list.Average();//finds the average of the list and sets the value of the average parameter
            sum = list.Sum();//finds the sum of the list and sets the value of the sum parameter
        }
    }
}
