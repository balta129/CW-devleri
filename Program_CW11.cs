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
    public class Program_CW11
    {
        public static void Main_CW11(string[] args)
        {
            /* https://www.codewars.com/kata/52742f58faf5485cae000b9a

            */
            int second = 132030240;                     //  4 years, 68 days, 3 hours and 4 minutes 5.788.800
            int year = second/31536000;
            int day = (second-year*31536000)/86400;
            int hour =(second-(year*31536000 + day * 86400))/ 3600;
            int minute = (second-(year*31536000 + day * 86400 + hour * 3600))/60;
            int saniye = second-(year*31536000 + day * 86400 + hour * 3600 + minute * 60);
            int a = 0;
            string[] array = new string [5];

            if(year > 1)
            {
                string year1 = year.ToString()+" years";
                array[a] = year1;
                a++;
            }
            else if (year == 1)
            {
                string year1 = year.ToString()+" year";
                 array[a] = year1;
                a++;
            }
            else
            {
            
            }
            if(day > 1)
            {
                string day1 = day.ToString()+" days";
                 array[a] = day1;
                a++;
            }
            else if (day == 1)
            {
                string day1 = day.ToString()+" day";
                array[a] = day1;
                a++;
            }
            else
            {

            }
            if(hour > 1)
            {
                string hour1 = hour.ToString()+" hours";
                array[a] = hour1;
                a++;
            }         
            else if(hour == 1)
            {
                string hour1 = hour.ToString()+" hour";
                array[a] = hour1;
                a++;
            }
            else
            {

            }
            if(minute > 1)
            {
                string minute1 = minute.ToString()+" minutes";
                array[a] = minute1;
                a++;
            }
            else if (minute == 1)
            {
                string minute1 = minute.ToString()+" minute";
                 array[a] = minute1;
                a++;
            }
            else
            {
            
            }
            if(saniye > 1)
            {
                string saniye1 = saniye.ToString()+"  seconds";
                 array[a] = saniye1;
                a++;
            }
            else if (saniye == 1)
            {
                
                string saniye1 = saniye.ToString()+" second";
                array[a] = saniye1;
                a++;
            }
            else
            {
            
            }
            if(a == 0)
            {
                Console.Write("now");
            }
            else
            {
            for(int i = 0; i < a; i++)
            {
                if(i != a-1)
                {
                    if(i != a-2)
                    {
                        Console.Write(array[i]+", ");
                    }
                    else
                    {
                        Console.Write(array[i]+" and ");
                    }
                }
                else
                {
                    Console.Write(" "+array[i]);
                }
            }
            }   
        }
    }
}
