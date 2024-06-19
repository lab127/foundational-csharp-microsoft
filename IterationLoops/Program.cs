for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine($"\"i += 3\" to skip two values after each iteration. i = {i}");
}

Console.WriteLine("-------------");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Increment by 1. i = {i}");
    if (i == 3) break;
}

Console.WriteLine("-------------");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"Decrement by 1. i = {i}");
    if (i == 2) break;
}

Console.WriteLine("-------------");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// foreach (var name in names)
// {
//     if (name == "David") name = "Sammy";
//     Console.WriteLine(name);
// }

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}