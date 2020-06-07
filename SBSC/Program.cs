using System;
using System.Collections.Generic;
using System.Linq;

namespace SBSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SBSC ASSIGNMENT AND SOLUTION CONSOLE APP!");

            Console.WriteLine(" ");

            Console.WriteLine("====================Start of Solution to Question One ========================");
            Console.WriteLine("Enter string of numbers separated by an hyphen '-' e.g 1-2-3-5 etc");           
            
            string k=  Console.ReadLine();

            // Checking if input contains letter before proceeding
          
        
            if (k.Any(Char.IsLetter))
            {
                Console.WriteLine("Input can not contain letters===>Exiting and try again");
                                
            }
            else
            {
                var result = QuestionOne(k);
                Console.WriteLine( "Output is " +result);
                Console.WriteLine(" ");
               
            }
            Console.WriteLine("====================End of Question One ========================");

            Console.WriteLine("");

            

            Console.WriteLine("====================Start of Solution to Question Three ========================");
            Console.WriteLine("Enter any words of choice e.g International to see the letters with their number of occurrence");
            var word =Console.ReadLine();
            var myResult=  QuestionThree(word);
            Console.WriteLine("");
            Console.WriteLine(myResult);

            Console.ReadLine();

            Console.WriteLine("====================End of Question One ========================");

    
        }


        public static bool QuestionOne(string inputString)
        {
            //Remove hyphen from string of numbers
            string numbers = inputString.Replace("-","");

            //convert string of numbers to array starts here

            int[] intArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                intArray[i] = int.Parse(numbers[i].ToString());

            }


            // ends here

            //calculating the difference between arrays of numbers from the next element starts here

            int[] intervalDiff = new int[numbers.Length-1];
           

            for(int j = 0; j < intervalDiff.Length; j++)
            {
               
                intervalDiff[j]= intArray[j]- intArray[j + 1];

            }


            //ends here

            //checking if the differrence is the same for all elements starts here using LINQ 

           int result= intervalDiff.Distinct().Take(2).Count();
          
            bool output= (result == 1) ? true : false;
           
            return output;
        }

       

        public static string QuestionThree(string StringValue)
        {

            string[] numberOfOccurList = new string[StringValue.Length];
            int letterCount;

            for(int i = 0; i < StringValue.Length; i++)
            {

                letterCount = StringValue.ToCharArray().Count(c => c == StringValue[i]);

                numberOfOccurList[i]=(StringValue[i] + letterCount.ToString());


            }

            var numOfOccurs = string.Join("", numberOfOccurList.Distinct());
           


            return numOfOccurs;
        }


        public static string QuestionTwo(string listSTring)
        {

            var stringArray = listSTring.Split(" ");

            //convert string of numbers to array starts here

            List<string> numberList = new List<string>();

            foreach (var item in stringArray)
            {
                numberList.Add(item);
            }


            int[] intArray = new int[listSTring.Length];

            for (int i = 0; i < listSTring.Length; i++)
            {
                intArray[i] = int.Parse(listSTring[i].ToString());

            }



            for (int j = 0; j < listSTring.Length - 1; j++)
            {

                numberList.Add((intArray[j] - intArray[j + 1]).ToString());

            }


            
            return "";
        }

    }
}
