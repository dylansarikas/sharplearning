for (int i = 1; i <= 100; i++)
{
    string output = "";

    if (i % 3 == 0)
        output += "Fizz";
    if (i % 5 == 0)
        output += "Buzz";

    Console.WriteLine((output == "") ? $"{i}" : $"{i} - {output}");
}