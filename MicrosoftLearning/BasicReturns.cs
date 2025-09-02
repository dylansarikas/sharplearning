Random random = new();

Console.WriteLine("Would you like to play? (Y/N)");
string? response = Console.ReadLine();
if (ShouldPlay(response)) 
{
    PlayGame();
}

void PlayGame()
{
	var play = true;

	while (play)
	{
		var target = random.Next(1, 6);
		var roll = random.Next(1, 7);

		Console.WriteLine($"Roll a number greater than {target} to win!");
		Console.WriteLine($"You rolled a {roll}");
		Console.WriteLine(WinOrLose(target, roll));
		Console.WriteLine("\nPlay again? (Y/N)");
		response = Console.ReadLine();

		play = ShouldPlay(response);
	}
}

bool ShouldPlay(string answer) => answer == "Y" || answer == "y";

string WinOrLose(int target, int roll) => roll > target ? "Yay, you win" : "Boo, you lose!";