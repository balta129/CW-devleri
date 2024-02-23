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
    public class Program_CW6
    {
        public static void Main_CW6(string[] args)
        {
            /*
            Question Name : Equal Sides Of An Array
            */
          
            
           
                int [] numbers = {1,1,10,50,100,50,-100,-50,-10,-1,-1,324};
                
                
                int sumright = 0;
                int sumleft = 0;
                for(int i = 0; i < numbers.Length; i++)
                {
                    for(int j = numbers.Length-1; j > i; j--)
                    {
                       sumright = sumright + numbers[j];
                    }
                    for(int p = i; p > 0; p--)
                    {
                        if(i == 0)
                        {
                        sumleft = 0;
                        }
                        else
                        {
                        sumleft = sumleft + numbers[p-1];
                        }
                    }
                    if(sumright == sumleft)
                    {
                        Console.Write("Result: "+i);
                        break;
                    }
                    else
                    {
                        sumright = 0;
                        sumleft = 0;
                    }
                }
                
            
 
            

          
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
                
        
        }
  
    }
}