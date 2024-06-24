Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
// --------------------
Console.WriteLine("a" == "a ");
// --------------------
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
// --------------------

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// --------------------

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// --------------------

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False


// --------------------
/**
CONDITIONAL OPERATOR 
*/
// incline conditional operator or one line if else
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

/**
Code challenge: write code to display the result of a coin flip
In this challenge, you'll implement a conditional operator to simulate a "coin flip". The resulting decision logic will display either heads or tails.
*/
var rand = new Random();
string coinFlip = rand.Next(2) == 1 ? "head" : "tail";
Console.WriteLine($"Coind fliped to: {coinFlip}");

