List<int> numbers = new();
Dictionary<int, string> promptStates = new()
{
    { 1, "Enter a number or type 'exit' to quit:" },
    {
        2,
        "Enter a number to continue. Type 'exit' to quit; or enter 'Bubble' to sort the list using Bubble Sort:"
    },
    { 3, "Invalid input. Please enter a valid number, 'bubble' to sort or 'exit' to quit." },
};

Console.WriteLine(promptStates[1]);

while (true)
{
    string? input = Console.ReadLine();
    if (input?.ToLower() == "exit")
        break;

    if (input?.ToLower() == "bubble")
    {
        BubbleSort(numbers);
        Console.WriteLine($"Sorted list: {string.Join(", ", numbers)}");
        Console.WriteLine(promptStates[2]);
        continue;
    }

    if (int.TryParse(input, out int number))
    {
        numbers.Add(number);
        Console.WriteLine($"numbers contains: {string.Join(", ", numbers)}");
        Console.WriteLine(promptStates[2]);
    }
    else
    {
        Console.WriteLine(promptStates[3]);
    }
}

static void BubbleSort(List<int> list)
{
    bool swapped;
    for (int i = 0; i < list.Count - 1; i++)
    {
        swapped = false;
        for (int j = 0; j < list.Count - i - 1; j++)
        {
            if (list[j] > list[j + 1])
            {
                (list[j], list[j + 1]) = (list[j + 1], list[j]);
                swapped = true;
            }
        }
        if (!swapped)
            break;
    }
}
