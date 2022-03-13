//official documentation: https://docs.microsoft.com/en-us/dotnet/csharp/
//Better documentation: https://www.w3schools.com/cs/cs_syntax.php
//file extention : .cs
//import libraries using "using libraryname"

using System; // System is a namespace, Console is one of its classes
using System.io; // Allows use of File methods

//Tabs do not effect C#, but all statements must end in ;
/* Multiline Comment */

namespace C# { // C# Uses OOP Heavily, a namespace is similar to a library, and is mainly used to hold classes, A namespace does not need to match the file name
    class program{
        static void main(){ // main is automatically run when a class is initalized.

            // Command Line Basics
            string userName = Console.ReadLine();           //Gets Input From Console
            Console.WriteLine("Username is: " + userName);  //Prints line to console

        }

        static void variables(){
            // Variables declaration must declare a variable type
            int myNum = 5; // 32 bit int
            long myLong = 5; // 64 bit int

            float myFloat = 5.33F; //32 bit float must end in F
            double myDoubleNum = 5.99D; // 64 bit float

            char myLetter = 'D';
            string myText = "Hello"; 
            
            bool myBool = true;


            const int myNum = 15; // makes the variable unchangeable
            //Casting
            double myDouble = myInt;       // Automatic Casting
            int myInt = (int) myDouble;    // Manual casting: double to int, otherwise causes error

            Convert.ToString(myInt);         // Explicit Conversion
            Convert.ToDouble(myInt);
            Convert.ToInt32(myDouble);
            Convert.ToString(myBool);

            // Arrays
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; 
            string[,] drinks = {{"jack", "coke"}}; //nested array needs to be of the same type, use dictionaries instead
        }
        static void math(){
            1+1; // Addition
            1-1; // Subtraction
            1*2; // Multiplication
            1^2; // Powers
            1/1; // Division
            1%2; // Remander
            1++; // Increment
            1--; // Decrement

            // variables can quickly be opperated on by putting an equal sign after the operation symbol, +=, -=, etc

            // Logic
            1 == 1;
            2 != 1;
            3 > 2;
            2 < 3;
            3 >= 2;
            2 <= 3;

            // && AND
            // || OR
            // !  NOT

            Math.min(5,10);
            Math.max(5,10);
            Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);

            // String Stuff
            string txt = "Hello";
            txt.ToUpper();
            txt.ToLower();
            txt.Length;
        }
        static void IfElseAndSwitch(){

            if (true)
            {
            // block of code to be executed if condition1 is True
            } 
            else if (true) 
            {
            // block of code to be executed if the condition1 is false and condition2 is True
            } 
            else
            {
            // block of code to be executed if the condition1 is false and condition2 is False
            }

            // Switch statement is similar to an if statement, but uses less computations and more memory
            switch(2)
            {
            case 1:
                // code block
                break;
            case 2:
                // code block
                break;
            default:
                // code block
                break;
            }

        }

        static void Loops(){

            // While Loop
            while(true){
                // does something
            }
            do
            {
                // something, once even if while loop is false, if while loop is true this will get looped however
            }
            while(false);

            // For
            for (int i = 0; i < 5; i++) // First condition is run once, second is the requirement for the loop to keep going, the third is run every iteration
            {
            Console.WriteLine(i);
            }

            // For Each
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            foreach (string i in cars) // for variable in the array
            {
            Console.WriteLine(i);
            }

            // break, gets out of the loop
            // continue, gets out of the current iteration but continues the loop
        }
        static void functions(){
            // static restricts the function to this class
            // void refer to possible return values, if you want something to be returned set this to the variable name Eg. String, Double, Int
            
        }
    }
    class ClassExample // : program, will cause this class to inherit from program
    {
        public string color = "red";
        public string color {
            get {return color;}
            set {color = value;}
        }
        // obj.color will now return red even outside of the class
        // obj.color = "blue" will now change the color even outside of the class

        public string model;

        // Constructor ran when object is created, you can create multiple instructors if you wish to have different possible creation parameters
        public ClassExample(){
            model = "Mustang";
        }
        // Ran once class is initalized
        static void Main(string[] args)
        {
            ClassExample myObj = new ClassExample();
            Console.WriteLine(myObj.color);
        }

    }
    // Access Specifiers
    // public - members are accessable outside of the class
    // private - members are not accessa
    // Enums is a special class that represents a bunch of constant variables
    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }
    class FileUsage{
        File.AppendText(); // Adds text to existing file
        File.Copy(); // Copies a file
        File.Create(); // Creates a file
        File.Delete(); //  delete a file
        File.Exists(); // Returns true or false
        File.ReadAllText(); // Returns all text
        File.Replace(); // Replaces one file with another
        File.WriteAllText(); //Creates a new file and writes contents to it
        // More info found here https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=netframework-4.8
    }
    class Exceptions{
        try
        {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
        }
        catch (Exception e)
        {
        Console.WriteLine(e.Message);
        }
        finally {
            // Regardless of the result it runs this code
            throw new ArithmeticException("This allows you to create a  new error statement");
        }
    }
}