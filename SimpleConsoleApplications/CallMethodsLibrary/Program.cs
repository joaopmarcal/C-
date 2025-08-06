Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50,101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//challenge
//Code challenge: Implement a method of the Math class that returns the larger of two numbers
int firstValue = 700;
int secondValue = 600;
int largeValue;

Console.WriteLine(System.Math.Max(firstValue, secondValue));