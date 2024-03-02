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
    public class Program_CW8
    {
        public static void Main_CW8(string[] args)
        {
            /* https://www.codewars.com/kata/52685f7382004e774f0001f7/csharp
            */
            Console.Write("Please enter the second (max 359999): ");
            int second = Convert.ToInt32(Console.ReadLine());
            /* 1 minute = 60 seconds
               1 hour = 60 minutes = 3600 seconds 
            */
            if(second >= 0 && second < 60)
            {
                if(second < 10)
                {
                    Console.Write("Timer: 00.00.0"+second);
                }
                else
                {
                Console.Write("Timer: 00.00."+second);
                }
            }
            else if(second > 59 && second < 3600)
            {
                int minute = second/60;
                decimal x = decimal.Round(minute);
                int a = minute*60;
                int b = second-a;
                if (x < 10)
                {
                    if(b < 10)
                    {
                        Console.Write("Timer: 00.0"+x+".0"+b);
                    }
                    else
                    {
                        Console.Write("Timer: 00.0"+x+"."+b);
                    }
                }
                else
                {
                    if(b < 10)
                    {
                        Console.Write("Timer: 00."+x+".0"+b);
                    }
                        else
                    {
                        Console.Write("Timer: 00."+x+"."+b);
                    }
                }

            }
            else if(second > 3599 && second <360000)
            {
                int hour = second/3600;                 
                decimal x = decimal.Round(hour);
                int a = hour*3600;                      
                int b = second-a;                       
                int minute = b/60;                     
                decimal k = decimal.Round(minute);
                int c = minute*60;                      
                int d = b-c;   
                if(x < 10)
                {
                    if(k < 10)
                    {
                        if(d < 10)
                        {
                            Console.Write("Timer: 0"+x+".0"+k+".0"+d);
                        }
                        else
                        {
                            Console.Write("Timer: 0"+x+".0"+k+"."+d);
                        }
                    }
                    else
                    {
                        if(d < 10)
                        {
                            Console.Write("Timer: 0"+x+"."+k+".0"+d);
                        }
                        else
                        {
                            Console.Write("Timer: 0"+x+"."+k+"."+d);
                        }
                    }
                }
                else
                {
                    if(k < 10)
                    {
                        if(d < 10)
                        {
                            Console.Write("Timer: "+x+".0"+k+".0"+d);
                        }
                        else
                        {
                            Console.Write("Timer: "+x+".0"+k+"."+d);
                        }
                    }
                    else
                    {
                        if(d < 10)
                        {
                            Console.Write("Timer: "+x+"."+k+".0"+d);
                        }
                        else
                        {
                            Console.Write("Timer: "+x+"."+k+"."+d);
                        }
                    }
                }
               

            }
        }
    }
}
