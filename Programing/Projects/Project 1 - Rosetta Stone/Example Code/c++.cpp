//official documentation: https://www.w3schools.com/cpp/default.asp
//Better documentation: https://www.w3schools.com/cs/cs_syntax.php
//file extention : .cpp
//import libraries using "using libraryname"
#include <iostream> // Imputs output stream
using namespace std; // imports standard library

//Tabs do not effect C#, but all statements must end in ;
/* Multiline Comment */

void main(){ // Runs automatically

    // Command Line Basics 
    cout << "Hello World \n"; // prints hello world, \n creates a new line
    cin >> int x; // gets user import from keyboard

    // insertion operator <<
    // extraction operator >>
    std::cout << "We technically dont need to import namespace if we do this";

}

void Variables(){
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
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; // Put a number in the [] if you want to be able to set more values later
    string[,] drinks = {{"jack", "coke"}}; //nested array needs to be of the same type, use dictionaries instead
}

void math(){
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

    min(5,10); // Returns the lowest value
    max(5,10); // Returns the highest value
    #include <cmath>
    Sqrt(64); // Returns the square root
    Abs(-4.7); // Returns the absolute value
    Round(9.99); // Rounds to the nearest whole number
    // more can be found on https://www.w3schools.com/cpp/cpp_math.asp

    // String Stuff
    string txt = "Hello";
    string txt2 = txt.append(" World"); // + also works but this is much faster
    txt.ToUpper();
    txt.ToLower();
    txt.size(); // .length() also works

    // Strings are just arrays
    txt[0] == "H";
}

void IfElseSwitch(){
    if (true)
    {
    // block of code to be executed if condition1 is True
    } 
    else if (false) 
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

void loops(){
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

void references(){
    string food = "Pizza";  // A food variable of type string
    string* ptr = &food;    // A pointer variable, with the name ptr, that stores the address of food

    // Output the value of food (Pizza)
    cout << food << "\n";

    // Output the memory address of food (0x6dfed4)
    cout << &food << "\n";

    // Output the memory address of food with the pointer (0x6dfed4)
    cout << ptr << "\n";
}

void functions(){
    // void refer to possible return values, if you want something to be returned set this to the variable name Eg. String, Double, Int
}

class MyClass{
    public:
        int myNum;
        string MyString;
        
        // Constructor, create mutiple constructors if you want mutiple parameters
        myClass(){
            myNum = 5
        }
        void myMethod(){
            cout << "Hello World";
        }
}
// Constructor definition outside the class
MyClass::MyClass(string x, string y, int z) {
  string brand = x;
  string model = y;
  int year = z;
}

void objectexample(){
    MyClass MyObj;
    myObj.myNum = 15;
    myObj.MyString = "Hello";

    cout << myObj.myNum << "\n";
    cout << myObj.myString;

    myObj.myMethod();
}

// Continue From Here if needed.
// https://www.w3schools.com/cpp/cpp_access_specifiers.asp