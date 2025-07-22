Console.WriteLine("Please enter your security level: ");
string? userInput;
bool correctLevel = false;

do
{
    userInput = Console.ReadLine();
    userInput = userInput?.Trim().ToLower();
    if (userInput == "user" || userInput == "admin" || userInput == "manager")
        correctLevel = true;
    else
        Console.WriteLine("Please enter a correct security level");
} while (correctLevel == false);

Console.WriteLine($"Secturity level of {userInput} was accepted");