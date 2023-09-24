bool flag = true;
/* 
1. single line is valid but never use single-line form. example: if (flag) Console.WriteLine(flag);
2. Using braces is always accepted, and required if any block of an if/else if/.../else statement
3. Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.
*/
if (flag)
    Console.WriteLine(flag);


// one line valid code block
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

// multi line code block without braces, more readable
name = "bob";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");