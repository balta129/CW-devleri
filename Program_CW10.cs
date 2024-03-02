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
    public class Program_CW10
    {   
        public static void Main_CW10(string[] args)
        {
            /* https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp
            */
            string s = "aabbQcc";
            char[] array = new char[s.Length];

            for(int i = 0; i < s.Length; i++)
            {
                array[i] = char.ToLower(s[i]);
            }
           int b = 0;
            for(int i = 0; i < s.Length; i++)
            {   
                int a = 0;
                
                 
                for(int j = 0; j < s.Length; j++)
                {
                    if(array[i] == array[j])
                    {   
                        a++;
                        b++;
                        if(a > 1)
                        {
                            
                            break;
                        }
                    }
                }
                if(a == 1)
                {
                    Console.Write(s[i]);
                    break;
                }
                else if( b >= s.Length*2)
                {
                    Console.Write(".");
                    break;
                }       
            }   
        }
    }
}
