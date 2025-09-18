List<int> numbers = new();
bool condition = true;

Console.WriteLine("Enter a number or type 'exit' to quit:");
while (condition)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        condition = false;
    }

    if (int.TryParse(input, out int number))
    {
        numbers.Add(number);
        BubbleSort(numbers);
        Console.Write($"numbers contains: ");
        foreach (var num in numbers)
        {
            Console.Write($"{num}, ");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number or 'exit' to quit.");
    }
}

static void BubbleSort(List<int> list)
{
    for (int i = 0; i < list.Count - 2; i++)
    {
        int temp = list[i];
        if (list[i] > list[i + 1])
        {
            list[i] = list[i + 1];
            list[i + 1] = temp;
        }
    }
}
