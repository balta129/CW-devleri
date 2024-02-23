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
    public class Program_CW5
    {
        public static void Main_CW5(string[] args)
        {
            /*
            Question Name : Duplicate Encoder
            The goal of this exercise is to convert a string to a new string where each character in the new string is "("
            if that character appears only once in the original string, or ")" if that character appears more than once in the original string
            Ignore capitalization when determining if a character is a duplicate.
            */
            /* using System;
                public class Demo {
                 public static void Main() {
                 string str = "Welcome to the Planet!";       -------->>>> Aldığımız string'in harflerini sırayla almak için.
                 string res = str.Substring(0, 1);
                  Console.WriteLine(res);
                 }
                    }
             */
            
           
            Console.WriteLine("Input the string : ");
            string a = Console.ReadLine();
 
            string[] array = new string[a.Length];
            string[] array2 = new string[a.Length];
             

            for(int i = 0; i < a.Length; i++)
            {
                array[i] = a.Substring(i,1).ToLower();
            }
            
            for(int i = 0; i < a.Length; i++)
            {
                array2[i] = array[i];
            }

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    if(i != j && array[i] == array[j])
                    {
                        array2[i] = "0";
                    }
                    
                }
            }
            for(int i = a.Length-2; i > 0; i--)
            {
                if(array[a.Length-1] == array[i])
                {
                    array2[a.Length-1] = "0";
                }
            }
 
            for(int i = 0; i < a.Length; i++)
            {
               if(array2[i] == "0")
               {
                Console.Write(")");
               }
               else
               {
                Console.Write("(");
               }
            }
          

          
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
  
    }
}