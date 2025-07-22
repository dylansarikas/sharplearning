Random random = new();
int heroHealth = 10;
int monsterHealth = 10;

do
{
    int heroAttackRole = random.Next(1, 11);
    monsterHealth -= heroAttackRole;
    Console.WriteLine($"Hero attacks the monster for {heroAttackRole} damage!  Monster has {monsterHealth} health remaining!");
    if (monsterHealth > 0)
    {
        int monsterAttackRole = random.Next(1, 11);
        heroHealth -= monsterAttackRole;
        Console.WriteLine($"Monster attacks the hero for {monsterAttackRole} damage!  Hero has {heroHealth} health remaining!");
    }
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine((heroHealth > monsterHealth) ? "Hero has won!" : "Monster has won!");