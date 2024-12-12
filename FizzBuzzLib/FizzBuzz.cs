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
    }
}
