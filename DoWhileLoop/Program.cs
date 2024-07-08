Random random = new Random();

int current = 0;

// The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
/**
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

current = random.Next(1, 11);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    // assign new random number to current variable
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");
*/

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);