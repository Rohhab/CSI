var csInternshipUrl = "https://github.com/cs-internship";

Console.WriteLine("Hello, World!");
Console.WriteLine("This is C# 13.0!");
Console.WriteLine("Enjoy coding!");
Console.WriteLine();
Console.WriteLine("Join CS Internship Program:");

var CallToAction = $"Check this out: {csInternshipUrl.Trim()}";
var replacedString = CallToAction.Replace("Check this out:", "Did you enjoy");
Console.WriteLine($"{CallToAction}");
Console.WriteLine($"{replacedString}?");
