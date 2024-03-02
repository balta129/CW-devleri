using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_CW9
    {
        public static void Main_CW9(string[] args)
        {
            /* https://www.codewars.com/kata/530e15517bc88ac656000716
            */
            string word = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = new char [word.Length];
            string cw = "Create a function";
            char [] array2 = new char [cw.Length];
           
            for(int i = 0; i < word.Length; i++)
            {
                array[i] = word[i];
            }
            for(int i = 0; i < cw.Length; i++)
            {
                array2[i] = cw[i];
            }

            for(int i = 0; i < cw.Length;i++)
            {
                bool letter = false;
               for(int j = 0; j < word.Length; j++)
               {
                 if (j <= 12)
                {
                    if(array2[i] == array[j])
                    {   letter = true;
                        Console.Write(array[j+13]);
                    }
                }
                else if (j >12 && j < 26)
                {
                    if(array2[i] == array[j])
                    {letter = true;
                        Console.Write(array[j-13]);
                    }   
                }
                else if (j > 25 && j < 39)
                {
                    if(array2[i] == array[j])
                    {letter = true;
                        Console.Write(array[j+13]);
                    }   
                }
                else 
                {
                    if(array2[i] == array[j])
                    {letter = true;
                        Console.Write(array[j-13]);
                    }
                }
               }
               if(letter == false)
               {
                Console.Write(array2[i]);
               }
               
            } 
            for(int i = 0; i < cw.Length; i++)
            {
                Console.Write(array2[i]);
            }
           
            
        }
    }
}
