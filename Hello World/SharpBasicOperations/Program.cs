//Exercise - Perform addition with implicit data conversion
//add two numeric values

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//Mix data types to force implicit type conversions
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//Attempt a more advanced case of adding numbers and concatenating strings
string myName = "João";
int widgetSold = 7;
Console.WriteLine(myName + " sold " + widgetSold + 7 + " widgets.");

//Add parentheses to clarify your intention to the compiler
string theName = "Bob";
int theWidgetSold = 7;
Console.WriteLine(theName + " sold " + (theWidgetSold + 7) + " widgets.");

//Exercise - Perform math operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//Add code to perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

//good examples
//decimal decimalQuotient = 7 / 5.0m;
//decimal decimalQuotient = 7.0m / 5.0m;

//bad examples
//int decimalQuotient = 7 / 5.0m;
//int decimalQuotient = 7.0m / 5;
//int decimalQuotient = 7.0m / 5.0m;
//decimal decimalQuotient = 7 / 5;

//Add code to cast results of integer division
int first = 7;
int second = 5;
decimal result = (decimal)first / (decimal)second;
Console.WriteLine(result);

//Write code to determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Order of operations
//1-Parentheses (whatever is inside the parenthesis is performed first)
//2-Exponents
//3-Multiplication and Division (from left to right)
//4-Addition and Subtraction (from left to right)

//Write code to exercise C#'s order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//Exercise - Increment and decrement values
int value = 0; //value is now 0.
value = value + 5;// value is now 5.
value += 5;// value is now 10.
Console.WriteLine(value);

value = 0;// value is now 0.
value = value + 1;// value is now 1.
value++;// value is now 2.
Console.WriteLine(value);


//Operators like +=, -=, *=, ++, and --


int value3 = 1;

value3 = value3 + 1;
Console.WriteLine("First increment: " + value3);

value3 += 1;
Console.WriteLine("Second increment: " + value3);

value3++;
Console.WriteLine("Third increment: " + value3);

value3 = value3 - 1;
Console.WriteLine("First decrement: " + value3);

value3 -= 1;
Console.WriteLine("Second decrement: " + value3);

value3--;
Console.WriteLine("Third decrement: " + value3);

//Use the increment operator before and after the value
int value4 = 1;
value4++;
Console.WriteLine("First: " + value4);
Console.WriteLine($"Second: {value4++}");
Console.WriteLine("Third: " + value4);
Console.WriteLine("Fourth: " + (++value4));

//Complete the challenge to convert Fahrenheit to Celsius
//Challenge: Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal result1 = (fahrenheit - 32) * ((decimal)5/(decimal)9);
Console.WriteLine($"The temperature is {result1.ToString("F1")} Celsius.");

//another solution
int fahrenheit1 = 94;
decimal celsius = (fahrenheit1 - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");