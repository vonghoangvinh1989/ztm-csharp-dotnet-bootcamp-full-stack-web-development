using System.Globalization;

DateTime dateOfBirth = new DateTime(1989, 1, 23);
Console.WriteLine(dateOfBirth.DayOfWeek);

// Computed Values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing
DateTime localDate = DateTime.Parse("01.23.1989");
DateTime usDate = DateTime.Parse("01/23/1989", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate}, usDate: {usDate}");

// DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));