// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Use character literals
Console.WriteLine('b');

//Integer Literals
Console.WriteLine(123);

//Floating-point Literals
Console.WriteLine(0.25F);//float
Console.WriteLine(2.625);//double
Console.WriteLine(12.39816m);//decimal

//boolean literals
Console.WriteLine(true);
Console.WriteLine(false);

//Data types define capabilities

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

//string for words, phrases, or any alphanumeric data for presentation, not calculation
//char for a single alphanumeric character
//int for a whole number
//decimal for a number with a fractional component
//bool for a true/false value

//DataTypes

string secondName;

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

//Create your first variable
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

string myName = "Bob";
Console.WriteLine(myName);

//Declare implicitly typed local variables
var message = "Hello world!";//after that you cannot change the variable type
Console.WriteLine(message);

//Variables using the var keyword must be initialized
//var message;

//challenge
string personFirstName = "Bob";

int messages = 3;

float temperature = 34.4F;

Console.WriteLine("Hello, " + personFirstName + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " Celsius.");