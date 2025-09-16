/*Overview
Fighter name input, choose between 3 classes, glasscannon 99 - 100 damage, 1hp (chance to oneshot)
class 2 normal, 100 hp, 10-30 dmg
class 3 tank, 150 hp 5-20 dmg

To do: Make hp unable to go under 0, Class selection (might need to learn classes or something)

*/



int PlayerHP = 100;
int MonsterHP = 100;
string name = "";
string monster = "Curly Haired Baboon";
int Round = 1;
int PlayerMinDmg = 10;
int PlayerMaxDmg = 31;

Console.WriteLine("Welcome to the Fighting Game!");
Console.WriteLine("What's your name?");
name = Console.ReadLine();

string build = "";
Console.WriteLine("Choose your class!");
Console.WriteLine("1, Glasscannon(1 HP, 99-100 DMG)");
Console.WriteLine("2, Balance(100 HP, 10-30 DMG)");
Console.WriteLine("3, Tank (175 HP, 5-15 DMG)");
Console.WriteLine("4, Unpenetrable Fortress (5000 HP, 1 DMG)");
while (build != "1" && build != "2" && build != "3" && build != "4")
{
    build = Console.ReadLine();
}
if (build == "1")
{
    PlayerHP -= 99;
    PlayerMinDmg += 89;
    PlayerMaxDmg += 70;
    Console.WriteLine("Classcannon chosen!");
}
else if (build == "2")
{
    Console.WriteLine("Balance chosen!");
}
else if (build == "3")
{
    PlayerHP += 75;
    PlayerMinDmg -= 5;
    PlayerMaxDmg -= 15;
    Console.WriteLine("Tank chosen!");
}
else if (build == "4")
{
    PlayerHP += 4900;
    PlayerMinDmg -= 9;
    PlayerMaxDmg -= 29;
    Console.WriteLine("Unpenetrable Fortress chosen!");
}

while (PlayerHP > 0 && MonsterHP > 0)
{
    Console.WriteLine($"Round {Round}");
    Console.WriteLine("");

    Console.WriteLine($"{name}'s HP:{PlayerHP}, Monster HP: {MonsterHP}");
    Console.WriteLine("");

    int PlayerDMG = Random.Shared.Next(PlayerMinDmg, PlayerMaxDmg);
    Console.WriteLine($"{name}'s turn!");
    MonsterHP -= PlayerDMG;
    if (MonsterHP < 0) MonsterHP = 0; // Prevents hp going under 0, i.e. -20 hp
    Console.WriteLine($"{name} did {PlayerDMG} DMG");
    if (MonsterHP <= 0)
    {
        Console.WriteLine($"{monster} has been defeated!");
        break;
    }

        int MonsterDMG = Random.Shared.Next(10, 30);
        Console.WriteLine("");
        Console.WriteLine($"{monster}'s turn!");
        PlayerHP -= MonsterDMG;
        if (PlayerHP < 0) PlayerHP = 0; //same thing as before (Line 71)
        Console.WriteLine($"{monster} did {MonsterDMG} DMG");
        Round++;
        Console.WriteLine("");
        Console.WriteLine("Press a button to continue");
        Console.ReadKey();
        Console.WriteLine("");
}

Console.WriteLine("Fight over!");
Console.WriteLine($"Player HP:{PlayerHP}, Monster HP: {MonsterHP}");
/*
Removed tie mechanic as it should be patched
*/

if (PlayerHP >= 0 && MonsterHP == 0)
{
    Console.WriteLine("You won");
}
else if (PlayerHP == 0 && MonsterHP >= 0)
{
    Console.WriteLine("You loose");
}
Console.ReadLine();
