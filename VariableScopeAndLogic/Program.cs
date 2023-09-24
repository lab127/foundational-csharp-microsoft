bool flag = true;
int value = 0; // must be asigned
if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}

Console.WriteLine($"Outside of code block: {value}");
