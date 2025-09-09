//Overview
// Fighter name input, choose between 3 classes, glasscannon 99 - 100 damage, 1hp (chance to oneshot)
//class 2 normal, 100 hp, 10-30 dmg
//class 3 tank, 150 hp 5-20 dmg
int PlayerHP = 100;
int MonsterHP = 100;
string name = "";
string monster = "Curly Haired Baboon";
int Round = 1;


Console.WriteLine("Welcome to the Fighting Game!");
Console.WriteLine("What's your name?");
name = Console.ReadLine();

while (PlayerHP > 0 && MonsterHP > 0)
{
    Console.WriteLine($"Round {Round}");
    Console.WriteLine("");

    Console.WriteLine($"{name}'s HP:{PlayerHP}, Monster HP: {MonsterHP}");
    Console.WriteLine("");

    int PlayerDMG = Random.Shared.Next(10, 30);
    Console.WriteLine($"{name}'s turn!");
    MonsterHP -= PlayerDMG;
    Console.WriteLine($"{name} did {PlayerDMG} DMG");

    int MonsterDMG = Random.Shared.Next(10, 30);
    Console.WriteLine("");
    Console.WriteLine($"{monster}'s turn!");
    PlayerHP -= MonsterDMG;
    Console.WriteLine($"{monster} did {MonsterDMG} DMG");
    Round++;
    Console.WriteLine("");
    Console.WriteLine("Press a button to continue");
    Console.ReadKey();
    Console.WriteLine("");
}

Console.WriteLine("Fight over!");
Console.WriteLine($"Player HP:{PlayerHP}, Monster HP: {MonsterHP}");
if (PlayerHP <= 0 && MonsterHP <= 0)
{
    Console.WriteLine("Draw");
}
else if (PlayerHP >= 0 && MonsterHP == 0)
{
    Console.WriteLine("You won");
}
else if (PlayerHP == 0 && MonsterHP >= 0)
{
    Console.WriteLine("You loose");
}
Console.ReadLine();
