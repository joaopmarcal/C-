//Character escape sequences

Console.WriteLine("Hello\nWorld!"); //add a new line
Console.WriteLine("Hello\tWorld!"); //add a tab
Console.WriteLine("Hello \"World\"!"); //escape sequence
Console.WriteLine("c:\\source\\repos"); //use doubles backslashs to display just one backslash

//Format output using character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//Verbatim string literal
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

Console.Write(@"c:\invoices");

//Unicode escape characters
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

//Format output using unicode escape characters
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

//Exercise - Combine strings using string concatenation

string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

//concatenate multiple variables and literal strings

string name = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + name + "!");

//Exercise - Combine strings using string interpolation

string theName = "João";
string theMessage = $"Hello {theName}!";
Console.WriteLine(theMessage);

//Use string interpolation with multiple variables and literal strings

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//Complete the challenge
string russianProjectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\tc:\\Exercise\\{russianProjectName}\\data.txt");
Console.WriteLine($"\n{russianMessage}:\n\tc:\\Exercise\\{russianProjectName}\\ru-RU\\data.txt");

//Review the solution
string projectNameSolution = "ACME";
string englishLocation = $@"c:\Exercise\{projectNameSolution}\data.txt";
Console.WriteLine($"View English output:\n\t{englishLocation}\n");

string russianMessageSolution = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectNameSolution}\ru-RU\data.txt";
Console.WriteLine($"{russianMessageSolution}:\n\t{russianLocation}\n");