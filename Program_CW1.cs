using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_CW1
    {
        public static void Main_CW1(string[] args)
        {
            
        /*
        Question Name : Product Array (Array Series #5)
        productArray ({12,20}) ==>  return {20,12}
Explanation:
The first element in prod [] array 20 is the product of all array's elements except the first element

The second element 12 is the product of all array's elements except the second element .
--------------------------------------------------------------------------------------------------------
productArray ({1,5,2}) ==> return {10,2,5}

Explanation:
The first element 10 is the product of all array's elements except the first element 1

The second element 2 is the product of all array's elements except the second element 5

The Third element 5 is the product of all array's elements except the Third element 2.
---------------------------------------------------------------------------------------------------------
productArray ({10,3,5,6,2}) return ==> {180,600,360,300,900}

Explanation:
The first element 180 is the product of all array's elements except the first element 10

The second element 600 is the product of all array's elements except the second element 3

The Third element 360 is the product of all array's elements except the third element 5

The Fourth element 300 is the product of all array's elements except the fourth element 6

Finally ,The Fifth element 900 is the product of all array's elements except the fifth element 2
*/

            Console.Write("Input the number of the elements in the array : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] firstArray = new int [number];
            int[] secondArray = new int [number];

            Console.WriteLine("Input " + number + " elements in the array :");
                for(int i = 0; i < number; i++)
            {      
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }
                
                for(int i = 0; i < number; i++)
                {
                    int a = 1;
                    for(int j = 0; j < number; j++)
                    {
                        if( j == i)
                        {
                            a = a*1;
                        }
                        else
                        {
                        a = a*firstArray[j];
                        }
                     }
                     secondArray[i] = a;
                }   
                Console.WriteLine("The elements in the second array are: ");
                for(int i = 0; i < number; i++)
                {
                    Console.Write(secondArray[i] +" ");
                }




            
            
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}
