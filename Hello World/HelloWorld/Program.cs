// See https://aka.ms/new-console-template for more information

//usual Hello World
Console.WriteLine("Hello, World!");

// code bellows triggers an error because console is in lower-case
//console.WriteLine("Hello World!");
// message errors:(1,1): error CS0103: The name 'console' does not exist in the current context

// if you used single-quotation marks (') to surround the literal string Hello World! like so, it triggers an error
//Console.WriteLine('Hello World!');
// message errors:(1,19): error CS1012: Too many characters in character literal

// that`s how to comment the code
// Console.WriteLine("Hello World!");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

//The difference between Console.Write and Console.WriteLine

//Console.WriteLine() prints a message to the output console. At the end of the line, it adds a line feed similar to pressing Enter or Return to create a new line.

//Console.Write() prints another message to the same line.

Console.WriteLine("");
Console.WriteLine("Congratulations!");
Console.Write("You wrote your first lines of code.");

Console.WriteLine("");

Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");