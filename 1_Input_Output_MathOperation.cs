using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Input_Output_MathOperation
{
    /*
    Basic structure of console program

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    */

    class Program
    {
        static double calculateBMI (double height, double weight)
        {
            // This function return the calculated BMI
            return weight/(height*height); 
        }
        static string getBMIStatus(double bmi)
        {
            // This function will return BMI status

            if (bmi<0)
            {
                /*
                throw new Exception("BMI must above 0");
                ->  This throw is raise error
                    If the condition meet, this will raise an error to end the program
                    To not end the program, you should use (try...catch)
                */
                return "BMI must above 0";
            }

            // BMI Rates:
            // Under 18.5 -> Underweight
            // From 18.5 to 24.9 -> Normal weight
            // From 25 to 29.9 -> Overweight
            // Over 30 -> Obese

            if (bmi<18.5)
            {
                return "Underweight";
            }
            else if (bmi>=30)
            {
                return "Obese";
            }
            else if (bmi>=25 && bmi<30)
            {
                return "Overweight";
            }
            else
            {
                return "Normal weight";
            }
        }   
        static void Main(string[] args)
        {
            #region Input/Output

            // ***** Information retrieval and print initial info *****

            // To write, you can use:
            // Console.Write("What you want to say"); 
            // -> This will not add a new line after this code print to the console.
            // Console.WriteLine("What you want to say");  
            // -> This will add a new line to the console log after this code print to the console.

            Console.WriteLine("What is your name ?");

            // To read from console, you can use:
            // Console.ReadLine();
            // -> After it reads, it will not save to any variables as it is not assigned to any variable 
            // To read from console and assign to a variable
            // You can create a variable and then assign it to read from console.
            // In this case, I will create a variable to store my name.
            // string Name = Console.ReadLine();
            
            string MyName = Console.ReadLine();

            // Variable types:
            // - int: Store an integer 
            //  -> int age = 10

            // - double: Store floating number 
            //  -> int height = 1.75

            // - char: Store character, surrounded by single quotes 'a' 
            //  -> char a = 'a'

            // - string: Store string, text, surrounded by double quotes "a star is born" 
            //  -> string MyName = "Daniel Mini"

            // - bool: Store 2 value: True or False 
            //  -> bool isGraduated = True;

            // Constant: 
            // - Store constant, unchangable
            // - Keyword: const, combine with variable types above 
            //  -> const int MAX_AGE = 150


            // Normally, Console.ReadLine() returns a string
            // When make an input for number variable types, it will cause error as it is not converted to int. It still a string.
            // So, we have to convert it from string to int.
            // Usage: <Number data type> Number = <Number data type>.Parse(string) 
            //  -> int Number = int.Parse(string)

            Console.WriteLine("And how is your age ?");

            int MyAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your height ?");

            double MyHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your weight ?");

            double MyWeight = double.Parse(Console.ReadLine());

            // To bind the variable into output data, there are several ways to do it:
            // 1. String concatenation (simplest one but further extension is more complicated):
            // -> Console.WriteLine("Your name is: " + MyName + " and your age is: "+ MyAge);
            // 2. Composit formatting, use in-order placeholder:
            // -> Console.WriteLine("Your name is: {0} and your age is: {1}", MyName, MyAge);
            // 3. String interpolation like JavaScript (In C# 6.0 or later)
            // -> Console.WriteLine($"Your name is: {MyName} and your age is: {MyAge}");)

            Console.WriteLine($"Your name is {MyName} and your age is {MyAge}. Your height is {MyHeight:F2}");

            // {MyHeight:F2}: Format specifier, in this case MyHeight is ensured to display 2 decimal digits.


            #endregion

            #region Arithmetic Expression, Operation, Conditional Statement and Function

            // ############################

            // ***** Do the following calculate *****
            /*
                - Calculate BMI
                - Determine which case the user are into: Dangerous Underweight, Underweight, Normal, Overweight, Dangerous Overweight.
                - Calculate:
                    + Height * Age
                    + Weight * Age, return interger
                    + Age / Height

            */
            
            // Basic math (arithmetic) operation : 
            // + (addition) ,
            // - (subtract) , 
            // * (multiply) , 
            // / (divide, 10/3 = 3.3333333) , 
            // % (Modulus - get remainder value, 10%3 = 1)
            
            // Unary math operation: 
            // + (Positive number)
            // - (Negative number)
            // ++ (Add 1 to the number), 
            // -- (Subtract 1 to the number),
            // '! (Invert the boolean operation, e.g: If a!=b, means if a is not equal to b)
            // ~ (Bitwise inversion, invert the bits: ~100000 = 011111) 

            // Cast operator: Convert from big sized variable type to smaller variable type
            // E.g: double pi = 3.14 -> int a = (int) d, a = 3; 
            // => The double type will changed to int type

                     
            // Calculate BMI

            /*
            double BMI = MyWeight / (MyHeight*MyHeight);

            Console.WriteLine($"Your BMI is {BMI:F2}");
            */
            

            double BMI = calculateBMI(MyHeight,MyWeight);
            //Converted BMI calculation into function for extenability.
            Console.WriteLine($"Your BMI is {BMI:F2}");

            //Then check the BMI status

            // Conditional statement
            /* 
                if (condition) 
                {
                    <Execution block if the condition are True>
                }
                else if (condition)
                {
                    <Execution block if the else if condition are True>
                }
                else
                {
                    <Execution for other case>
                }
            */

            // View the usage of if-else statement on the function getBMIStatus

            Console.WriteLine("Your BMI status is in {0}", getBMIStatus(BMI));

            Console.WriteLine($"{MyHeight} * {MyAge} = {MyHeight*MyAge}");

            Console.WriteLine($"{MyWeight} * {MyAge} = {(int) MyWeight*MyAge}");
            
            Console.WriteLine($"{MyAge} / {MyHeight} = {MyAge/MyHeight}");

            #endregion

        }
    }

}