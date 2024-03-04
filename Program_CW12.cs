﻿using System;
using System.IO.Compression;
using Interval = System.ValueTuple<int, int>;
// https://www.codewars.com/kata/52b7ed099cdc285c300001cd/train/csharp

namespace Lesson009
{
    class Program_CW12  
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            int[,] result = new int[intervals.Length, 2];
            for (int i = 0; i < intervals.Length; i++)
            {
                int x1 = intervals[i].Item1;
                int y1 = intervals[i].Item2;
                result[i, 0] = x1;
                result[i, 1] = y1;
            }

            for (int i = 0; i < intervals.Length; i++)
            {
                bool changed = false;
                do
                {
                    int x1 = result[i, 0];
                    int y1 = result[i, 1];

                    if (x1 == y1)
                    {
                        break;
                    }

                    changed = false;
                    for (int j = 0; j < intervals.Length; j++)
                    {
                        x1 = result[i, 0];
                        y1 = result[i, 1];

                        if (j != i)
                        {
                            int x2 = result[j, 0];
                            int y2 = result[j, 1];

                            if(x1 >= x2 && x1 < y2)
                            {
                                if(y1 < y2)
                                {
                                result[i,0] = 0;
                                result[i,1] = 0;
                                changed = true;
                                }
                              else 
                                {
                                result[i,0] = y2;
                                changed = true;
                              }
                            }
                            else if (x1 == x2 && x1 < y2)
                            {
                                if(y1 < y2)
                                {
                                result[i,0] = 0;
                                result[i,1] = 0;
                                changed = true;
                                }
                            }
                            else if (x1 < x2 && x1 < y2)
                            {
                                if(y1 > x2 && y1 < y2)
                                {   
                                    result[i,1] = x2;           
                                      changed = true;                          
                                }
                              else if (y1 > y2)
                                {
                                result[j,0] = 0;
                                result[j,1] = 0;
                              }
                             
                              
                            }
                          

                        }
                    }
                } while (changed);
            }

            int sum = 0;
            for (int i = 0; i < intervals.Length; i++)
            {
                sum += result[i, 1] - result[i, 0];
            }

            return sum;
        }

        public static void Main_CW12(string[] args)
        {
            Console.WriteLine("Result: " + SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
        }
    }
}