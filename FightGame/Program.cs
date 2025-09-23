/*Overview
yes the monsters are lord of the mysteries references, yes i am obsessed with lotm
maybe add a shop? would be cool but hard to implement, maybe have to store money interger in diffrent file to prevent wiping when code reruns


TODO!

Loop the game after ending, put hp and damage into loop to reset after restarting.
Keep name out of loop so you dont need to re enter it

redo class system making it purchaseable upgrades instead of classes
*/
Console.Title = "Fighting Game";
int Wave = 1;
int Gold = 0;
bool Play = false;
string mainmenu = "";
string name = "";
int BaseHP = 100;
int BaseMinDMG = 10;
int BaseMaxDMG = 26;
int PlayerHP = 100;
int PlayerMinDmg = 10;
int PlayerMaxDmg = 26;
int MonsterHP = 100;
int playerhitchance = 50;
int MonsterBaseMinDMG = 10;
int MonsterBaseMaxDMG = 31;

void ShopMenu(int Wave)
{
    if (Wave <= 5)
    {
        Console.WriteLine($""" 
        Welcome to the shop!
        I can offer you some Grade 3 sealed artifacts, altough these come with downsides!
        You have {Gold} gold
        1. Mutated Sun Sacred Emblem, Increase minimum and max damage by 5, decrease hitchance by 2%. Costs 50 Gold
        2. Misfortune Cloth Puppet, Increase HP by 25, decrease min and max damage by 3. Costs 50 Gold
        3. Spirit Medium's Mirror, Increase hit chance by 5%, Decrease HP by 10. Costs 100 Gold
        4. Exit shop
        """);

    }
    else if (Wave >= 5 && Wave < 10)
    {
        Console.WriteLine(""" 
        Welcome to the shop!
        I see you're getting stronger, perhaps you can handle a Grade 2 sealed artifact now, beware the greater the power the greater the dangers!
        1. Blood Vessel Thief, Increase minimum and max damage by 10, Decrease hitchance by 10% Costs 150 Gold
        2. Pride Armor, Increase HP by 50, decrease min and max damage by 5. Costs 150 Gold
        3. Creeping Hunger, Increase hit chance by 10%, Decrease HP by 25. Costs 300 Gold
        4. Exit shop
        """);
    }
    else if (Wave >= 10 && Wave < 15)
    {
        Console.WriteLine(""" 
        Welcome to the shop!
        
        1. Blood Vessel Thief, Increase minimum and max damage by 10, Decrease hitchance by 10% Costs 150 Gold
        2. Pride Armor, Increase HP by 50, decrease min and max damage by 5. Costs 150 Gold
        3. Creeping Hunger, Increase hit chance by 10%, Decrease HP by 25. Costs 300 Gold
        4. Exit shop
        """);
    }
}


Console.WriteLine("Welcome to the Fighting Game!");
    Console.WriteLine("What's your name?");
    name = Console.ReadLine();
Console.WriteLine(""" 
Main Menu

1. Play
2. Shop
3. Exit

""");
while (mainmenu != "1" && mainmenu != "2" && mainmenu != "3")
{
    mainmenu = Console.ReadLine();
}
if (mainmenu == "1")
{
    Play = true;
}
else if (mainmenu == "2")
{
    ShopMenu(Wave);
    Console.ReadLine();
}



while (Play)
{
    if (Wave == 1)
    {
        Console.WriteLine("You have decided to tread the path to god hood becoming a Sequence 9 Seer, beware this path is filled will madness and despair");
    }
    else if (Wave == 2)
    {
        Console.WriteLine("You have managed to become a Sequence 8 Clown, Your power grows but so do the ravings");
    }
    else if (Wave == 3)
    {
        Console.WriteLine("You might have managed to become a Sequence 7 Magician, But your struggle is futile, give up now.");
    }
    else if (Wave == 4)
    {
        Console.WriteLine("Congratulations on becoming a Sequence 6 Faceless, I'll give it to you, you're not half bad");
    }
    MonsterHP = MonsterHP * Wave/2;
    string[] monsters = { "Curly Haired Baboon", "Amon", "Medici", "Lumian" };
    string monster = monsters[Random.Shared.Next(monsters.Length)];
    int Round = 1;
    string choice = "";

    while (PlayerHP > 0 && MonsterHP > 0)
    {
        Console.WriteLine($"Round {Round}");
        Console.WriteLine("");

        int turn = Random.Shared.Next(playerhitchance, 101);

        if (turn <= playerhitchance)
        {
            Console.WriteLine("Player goes first!");
            int PlayerDMG = Random.Shared.Next(PlayerMinDmg, PlayerMaxDmg);
            Console.WriteLine($"{name}'s turn!");
            MonsterHP -= PlayerDMG;
            if (MonsterHP < 0) MonsterHP = 0; // Prevents hp going under 0
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

            Console.WriteLine($"{name}'s HP:{PlayerHP}, Monster HP: {MonsterHP}");
            Console.WriteLine("");
            Round++
            Console.ReadLine();
        }
        else if (turn > playerhitchance)
        {
            int MonsterDMG = Random.Shared.Next(10, 30);
            Console.WriteLine("");
            Console.WriteLine($"{monster}'s turn!");
            PlayerHP -= MonsterDMG;
            if (PlayerHP < 0) PlayerHP = 0; //same thing as before (Line 71)
            Console.WriteLine($"{monster} did {MonsterDMG} DMG");
            if (PlayerHP <= 0)
            {
                Console.WriteLine($"{name} has been defeated!");
                break;
            }

            Console.WriteLine("");
            int PlayerDMG = Random.Shared.Next(PlayerMinDmg, PlayerMaxDmg);
            Console.WriteLine($"{name}'s turn!");
            MonsterHP -= PlayerDMG;
            if (MonsterHP < 0) MonsterHP = 0; // Prevents hp going under 0
            Console.WriteLine($"{name} did {PlayerDMG} DMG");
            Round++;
            Console.ReadLine();
        }
    }

    Console.WriteLine("Fight over!");
    Console.WriteLine($"Player HP:{PlayerHP}, Monster HP: {MonsterHP}");
    if (PlayerHP >= 0 && MonsterHP == 0)
    {
        Console.WriteLine("You won");
        Wave += 1;
        Gold += 50 * Wave/2;

    }
    else if (PlayerHP == 0 && MonsterHP >= 0)
    {
        Console.WriteLine("You loose");
        Wave = 1;
        Gold = 0;
        PlayerHP = BaseHP;
        PlayerMaxDmg = BaseMaxDMG;
        PlayerMinDmg = BaseMinDMG;

    }
    Console.WriteLine("Play again?");
    while (choice != "y" && choice != "n")
    {
        Console.WriteLine("Answer with Y / N");
        choice = Console.ReadLine().ToLower();
    }
    if (choice != "y")

    {
        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();
        Play = false;
    }
    else
    {
        Console.Clear();
        break;
    }
}