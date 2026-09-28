string message = "Hello World";
Console.WriteLine(message);

// empty string 
string emptyMessage = string.Empty;
Console.WriteLine(emptyMessage);

string stringWithDoubleQuote = "This is a string with a double quote: \" ";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);

string filePath2 = @"C:\temp";
Console.WriteLine(filePath2);

// string length
Console.WriteLine(filePath.Length);

// string concatenation
string firstName = "HoangVinh";
string lastName = "Vong";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// string interpolation
string fullNameInterpolated = $"{firstName} {lastName}";
Console.WriteLine(fullNameInterpolated);

Console.WriteLine($"The result is: {5*7}");

// Substrings
string first5characters = fullName.Substring(0, 5);
Console.WriteLine(first5characters);