int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"Integer quotient: {d}");
Console.WriteLine($"Integer remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int overflow = max + 3;
Console.WriteLine($"An example of integer overflow: {overflow}");

double ad = 19;
double bd = 23;
double cd = 8;
double dd = (ad + bd) / cd;
double ed = (ad + bd) % cd;
Console.WriteLine($"Integer quotient: {dd}");
Console.WriteLine($"Integer remainer: {ed}");

double doubleMax = double.MaxValue;
double doubleMin = double.MinValue;
Console.WriteLine($"The range of double is {doubleMin} to {doubleMax}");

decimal decimalMin = decimal.MinValue;
decimal decimalMax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decimalMin} to {decimalMax}");
