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
            //Iterate through replacement pairs
            foreach(KeyValuePair<int, string> pair in ReplacementPairs)
            {
                if(input % pair.Key == 0) //Check if input is exact multiple of key
                {
                    output += pair.Value; //Add string for that input
                }
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

        //Setup replacement pairs for FizzBuzz. In the passed-in dictionary, the first value in each pair is the number the input
        //should be a multiple of and the second value is the string to output if the input is a multiple of that value.
        public void SetReplacementPairs(Dictionary<int, string> pairs)
        {
            ReplacementPairs = pairs;
        }

        //Data for replacement pairs for FizzBuzzifyAnInt
        Dictionary<int, string> ReplacementPairs = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };
    }
}
