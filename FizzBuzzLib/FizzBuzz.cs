using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLib
{
    public class FizzBuzz //: IFizzBuzz
    {
        public string DemoMethod()
        {
            // Feel free to delete this method

            return "Hello World";
        }
        public string FizzBuzzifyAnInt(int input)
        {
            string output = ""; //Start with blank output
            //Add Fizz for multiple of 3
            if (input % 3 == 0)
            {
                output += "Fizz";
            }
            //Add Buzz for multiple of 5
            if (input % 5 == 0)
            {
                output += "Buzz";
            }
            //Replace cases that are neither with the input as a string
            if (output == "")
            {
                output = input.ToString();
            }
            return output;
        }

        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            List<string> result = new List<string>(); //Create empty result list
            //Test for invalid/not-implemented cases
            if(start < 0 || end < 0 || end < start)
            {
                //Throw not implemented exceptions
                throw new System.NotImplementedException();
            }
            //Generate FizzBuzz results for every integer between start and end inclusive
            for(int i=start; i<=end; i++)
            {
                result.Add(FizzBuzzifyAnInt(i));
            }
            return result;
        }

        public void SetReplacementPairs(Dictionary<int, string> pairs)
        {
            ReplacementPairs = pairs;
        }

        Dictionary<int, string> ReplacementPairs = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };
    }
}
