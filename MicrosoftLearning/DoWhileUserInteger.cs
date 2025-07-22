string? readResult;
int tryInteger = 0;
bool validInput = false;
bool correctRange = false;

Console.WriteLine("Enter a an integer value between 5 and 10: ");
do
{
    readResult = Console.ReadLine();
    validInput = int.TryParse(readResult, out tryInteger);
    if (validInput == true)
    {
        if (tryInteger <= 5 || tryInteger >= 10) Console.WriteLine("Integer not in correct range");
        else correctRange = true;
    }
    else
    {
        Console.WriteLine("Please enter a valid input");
    }
} while (validInput == false || correctRange == false);

Console.WriteLine($"Correct input of {tryInteger} has been accepted!");