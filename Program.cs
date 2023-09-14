Random dice = new Random();

int min = 1;
int max = 7;

int roll1 = dice.Next(min, max);
int roll2 = dice.Next(min, max);
int roll3 = dice.Next(min, max);

int maxToWin = max * 2 + 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    if (roll1 == roll2 && roll2 == roll3)
    {
        Console.WriteLine("You rolled triples! +6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("Your rolled doubles! +2 bonus to total!");
        total += 2;
    }
}


if (total >= maxToWin + 1)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two");
}
else
{
    Console.WriteLine("You win a kitten");
}

