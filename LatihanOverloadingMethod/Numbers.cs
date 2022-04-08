using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    internal class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if (number1 < number2) return number1;
            else return number2; 
   
          
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            int FindMinimum1=(number1<number2) ? number1 : number2;
            return ((int)number3 < FindMinimum1) ? (int)number3 : FindMinimum1;
            
        }
        public int FindMaximum(int number1, int number2)
        {
            if (number1 > number2) return number1;
            else return number2;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int FindMaximum1 = (number1 > number2) ? number1 : number2;
            return ((int)number3 > FindMaximum1) ? (int)number3 : FindMaximum1;
        }
    }
}
