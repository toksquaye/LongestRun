using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a function that finds the zero-based index of the longest run in a string. A run is a consecutive sequence of the same character. 
 * If there is more than one run with the same length, return the index of the first one.
 * For example, IndexOfLongestRun("abbcccddddcccbba") should return 6 as the longest run is dddd and it first appears on index 6. 
 * */

namespace ConsoleApplication3
{
    class Program
    {
        public class Run
        {
            public static int IndexOfLongestRun(string str)
            {
                var strArray = str.ToArray();
                int currentLongestIndex = 0; // starting index of longest sequence thus far
                int longestRun = 0;          // lenght of longest sequence thus far
                int startCurrSequence = 0;   // index of the current sequence

                for (int index = 1; index <= strArray.Length; index++)
                {
                    if(index == strArray.Length)
                    {
                        if (longestRun < (index - startCurrSequence))
                        {
                            longestRun = index - startCurrSequence;   //set new longest squence thus far
                            currentLongestIndex = startCurrSequence;

                        }
                        startCurrSequence = index; 
                    }
                    else if(strArray[index] != strArray[index-1] )
                    {
                        if(longestRun < (index - startCurrSequence))
                        {
                            longestRun = index - startCurrSequence;   //set new longest squence thus far
                            currentLongestIndex = startCurrSequence;

                        }
                        startCurrSequence = index;                        
                    }
                }
                return currentLongestIndex;
            }

            public static void Main(string[] args)
            {
                Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
                Console.ReadLine();
            }
        }
        
    }
}
