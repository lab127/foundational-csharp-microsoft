// Random random = new Random();
// int current = 0;

// The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
/**
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/


/*
current = random.Next(1, 11);
while (current >= 3)
{
    Console.WriteLine(current);
    // assign new random number to current variable
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");
*/

/*
do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/


/*
Code challenge - write code to implement the game rules
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

Random random = new Random();
int heroHealthPoint = 10;
int monsterHealthPoint = 10;
int attack;

do
{
    attack = random.Next(1, 11);
    monsterHealthPoint -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealthPoint} health.");
    if (monsterHealthPoint <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    };
    attack = random.Next(1, 11);
    heroHealthPoint -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealthPoint} health.");
    if (heroHealthPoint <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    };

} while (heroHealthPoint > 0 && monsterHealthPoint > 0);

// SOLUTION
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


// Manage user input during this challenge
// Console.WriteLine("-------------------------------------------");
// Console.WriteLine("| Manage user input during this challenge |");
// Console.WriteLine("-------------------------------------------");

// nullable string
// string? readResult;

/*
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
*/
/*
bool validEntery = false;
Console.WriteLine("Enter a string containing at least three characters:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntery = true;
        }
        else
        {
            Console.WriteLine("Invalid input! use at least 3 character.");
        }
    }
} while (validEntery == false);
*/

// Code project 1 - write code that validates integer input
/*
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("| Code project 1 - write code that validates integer input |");
Console.WriteLine("------------------------------------------------------------");

string? readIntInput;

int numericValue = 0;
bool validNumber = false;
do
{
    readIntInput = Console.ReadLine();
    validNumber = int.TryParse(readIntInput, out numericValue);
    if (numericValue >= 5 && numericValue <= 10)
    {
        validNumber = true;
        Console.WriteLine($"your numeric value input: {numericValue}");
    }
    else
    {
        Console.WriteLine("Invalid input! input must be a number between 5 and 10");
        validNumber = false;
    }
} while (validNumber == false);

*/

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("| Code project 2 - write code that validates string input |");
Console.WriteLine("------------------------------------------------------------");

string? readInput;
bool validString = false;
do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readInput = Console.ReadLine();
    string? inputValue = readInput.Trim().ToLower();
    string[] validatedInput = { "administrator", "manager", "user" };
    if (validatedInput.Contains(inputValue))
    {
        validString = true;
        Console.WriteLine($"Your input value ({readInput}) has been accepted.");
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{readInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (validString == false);
