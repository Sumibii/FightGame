/*Overview
yes the monsters are lord of the mysteries references, yes i am obsessed with lotm
maybe add a shop? would be cool but hard to implement, maybe have to store money interger in diffrent file to prevent wiping when code reruns


TODO!

Loop the game after ending, put hp and damage into loop to reset after restarting.
Keep name out of loop so you dont need to re enter it

redo class system making it purchaseable upgrades instead of classes
*/
string name = "";
    Console.WriteLine("Welcome to the Fighting Game!");
    Console.WriteLine("What's your name?");
    name = Console.ReadLine();
bool running = true;
    Console.Title = "Fighting Game";
    int Wave = 1;
    int Gold = 0;
    bool Play = false;
    string mainmenu = "";
    int BaseHP = 100;
    int BaseMinDMG = 10;
    int BaseMaxDMG = 26;
    int PlayerHP = 100;
    int PlayerMinDmg = 10;
    int PlayerMaxDmg = 26;
    int MonsterHP = 100;
    int playerhitchance = 50;
    int MonsterMinDMG = 10;
    int MonsterMaxDMG = 31;
while (running)
{
    Console.Title = "Fighting Game";

    void ShopMenu(int Wave)
    {
        if (Wave <= 5)
        {
            Console.WriteLine($""" 
        Welcome to the shop!
        I can offer you some Grade 3 sealed artifacts, altough these come with downsides!

        You have {Gold} gold

        1. Mutated Sun Sacred Emblem, Increase min/max damage by 5, decrease hitchance by 2%. Costs 50 Gold

        2. Misfortune Cloth Puppet, Increase HP by 25, decrease min/max damage by 3. Costs 50 Gold

        3. Spirit Medium's Mirror, Increase hit chance by 3%, Decrease HP by 10. Costs 100 Gold

        4. Exit shop

        Your current stats: HP:{PlayerHP}, Minimum Damage: {PlayerMinDmg}, Max Damage: {PlayerMaxDmg - 1}, Hitchance(%): {playerhitchance}.
        """);

        }
        else if (Wave >= 5 && Wave < 10)
        {
            Console.WriteLine($""" 
        Welcome to the shop!
        I see you're getting stronger, perhaps you can handle a Grade 2 sealed artifact now, beware the greater the power the greater the dangers!

        You have {Gold} gold

        1. Blood Vessel Thief, Increase min/max damage by 10, Decrease hitchance by 3% Costs 150 Gold

        2. Pride Armor, Increase HP by 50, decrease min/max damage by 5. Costs 150 Gold

        3. Creeping Hunger, Increase hit chance by 5%, Decrease HP by 25. Costs 300 Gold

        4. Exit shop

        Your current stats: HP:{PlayerHP}, Minimum Damage: {PlayerMinDmg}, Max Damage: {PlayerMaxDmg - 1}, Hitchance(%): {playerhitchance}.
        """);
        }
        else if (Wave >= 10 && Wave < 15)
        {
            Console.WriteLine($""" 
        Welcome to the shop!
        Grade 1 artifacts for sale, only for the strong.

        You have {Gold} gold

        1. Sword of the Sun, Increase min/max damage by 20, Decrease hitchance by 5% Costs 450 Gold

        2. Berserker's Armor, Increase HP by 100, decrease min/max damage by 10. Costs 450 Gold

        3. Eye of Omniscience, Increase hit chance by 7%, Decrease HP by 50. Costs 900 Gold

        4. Exit shop

        Your current stats: HP:{PlayerHP}, Minimum Damage: {PlayerMinDmg}, Max Damage: {PlayerMaxDmg - 1}, Hitchance(%): {playerhitchance}.
        """);
        }
        else if (Wave >= 15)
        {
            Console.WriteLine($""" 
        Welcome to the shop!
        Grade 0 artifacts, remnants of gods.

        You have {Gold} gold

        1. Book of Calamity, Increase min/max damage by 50, Decrease hitchance by 6% Costs 1500 Gold

        2. Black Emperor's Crown, Increase HP by 150, decrease min/max damage by 15. Costs 1500 Gold

        3. Die of Probability, Increase hit chance by 10%, Decrease HP by 100. Costs 3000 Gold

        4. Exit shop

        Your current stats: HP:{PlayerHP}, Minimum Damage: {PlayerMinDmg}, Max Damage: {PlayerMaxDmg - 1}, Hitchance(%): {playerhitchance};
        """);
        }
    }


    Console.WriteLine(""" 
Main Menu

1. Play
2. Shop
3. Exit

""");
    mainmenu = "";


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
        bool inShop = true;
        string itemchoice = "";
        while (inShop)
        {
            ShopMenu(Wave);
            itemchoice = "";
            while (itemchoice != "1" && itemchoice != "2" && itemchoice != "3" && itemchoice != "4")
            {
                itemchoice = Console.ReadLine();
            }
            if (itemchoice == "1" && Wave <= 5 && Gold >= 50)
            {
                Console.WriteLine("Mutated Sun Sacred Emblem bought!");
                PlayerMaxDmg += 5;
                PlayerMinDmg += 5;
                playerhitchance -= 2;
                Gold -= 50;
            }
            else if (itemchoice == "1" && Wave >= 5 && Wave < 10 && Gold >= 150)
            {
                Console.WriteLine("Blood Vessel Thief bought!");
                PlayerMaxDmg += 10;
                PlayerMinDmg += 10;
                playerhitchance -= 3;
                Gold -= 150;
            }
            else if (itemchoice == "1" && Wave >= 10 && Wave < 15 && Gold >= 450)
            {
                Console.WriteLine("Sword of the Sun bought!");
                PlayerMaxDmg += 20;
                PlayerMinDmg += 20;
                playerhitchance -= 5;
                Gold -= 450;
            }
            else if (itemchoice == "1" && Wave >= 15 && Gold >= 1500)
            {
                Console.WriteLine("Book of Calamity bought!");
                PlayerMaxDmg += 50;
                PlayerMinDmg += 50;
                playerhitchance -= 6;
                Gold -= 1500;
            }
            else if (itemchoice == "2" && Wave < 5 && Gold >= 50)
            {
                Console.WriteLine("Misfortune Cloth Puppet bought!");
                PlayerMaxDmg -= 3;
                PlayerMinDmg -= 3;
                BaseHP += 25;
                Gold -= 50;
            }
            else if (itemchoice == "2" && Wave >= 5 && Wave < 10 && Gold >= 150)
            {
                Console.WriteLine("Pride Armor bought!");
                PlayerMaxDmg -= 5;
                PlayerMinDmg -= 5;
                BaseHP += 50;
                Gold -= 150;
            }
            else if (itemchoice == "2" && Wave >= 10 && Wave < 15 && Gold >= 450)
            {
                Console.WriteLine("Berserker's Armor bought!");
                PlayerMaxDmg -= 10;
                PlayerMinDmg -= 10;
                BaseHP += 100;
                Gold -= 450;
            }
            else if (itemchoice == "2" && Wave >= 15 && Gold >= 1500)
            {
                Console.WriteLine("Black Emperor's Crown bought!");
                PlayerMaxDmg -= 15;
                PlayerMinDmg -= 15;
                BaseHP += 150;
                Gold -= 1500;
            }
            else if (itemchoice == "3" && Wave < 5 && Gold >= 100)
            {
                Console.WriteLine("Spirit Medium's Mirror bought!");
                playerhitchance += 3;
                BaseHP -= 15;
                Gold -= 100;
            }
            else if (itemchoice == "3" && Wave >= 5 && Wave < 10 && Gold >= 300)
            {
                Console.WriteLine("Creeping Hunger bought!");
                playerhitchance += 5;
                BaseHP -= 25;
                Gold -= 300;
            }
            else if (itemchoice == "3" && Wave >= 10 && Wave < 15 && Gold >= 900)
            {
                Console.WriteLine("Eye of Omniscience bought!");
                playerhitchance += 7;
                BaseHP -= 50;
                Gold -= 900;
            }
            else if (itemchoice == "3" && Wave >= 15 && Gold >= 3000)
            {
                Console.WriteLine("Die of Probability bought!");
                playerhitchance += 10;
                BaseHP -= 100;
                Gold -= 3000;
            }
            else if (itemchoice == "4")
            {
                inShop = false;
            }


        }
    }
    else if (mainmenu == "3")
    {
        running = false;
    }



    while (Play)
    {
        if (Wave == 1)
        {
            Console.WriteLine("You begin your journey into the mysteries as a Sequence 9 Seer, your mind haunted by visions of a dark and chaotic world.");
        }
        else if (Wave == 2)
        {
            Console.WriteLine("The threads of fate grow clearer, you manage to ascend to Sequence 8 Clown but the madness in your mind grows stronger with each step.");
        }
        else if (Wave == 3)
        {
            Console.WriteLine("You have embraced your new identity, chaos and humor mix with your rising power.");
        }
        else if (Wave == 4)
        {
            Console.WriteLine("You get accustomed to your ridiculous powers allowing you to advance to Sequence 7 Magician.");
        }
        else if (Wave == 5)
        {
            Console.WriteLine("You gain understanding of the arcane, manipulating energies unseen by normal people.");
        }
        else if (Wave == 6)
        {
            Console.WriteLine("Your spells strike with precision, yet every victory draws the eyes of darker forces. To prevent yourself from being recognized you advance to Sequence 6 Faceless.");
        }
        else if (Wave == 7)
        {
            Console.WriteLine("No one recognizes you, yet your influence grows and the world bends to your will. You just barely manage to become a Sequence 5 Marionetist");
        }
        else if (Wave == 8)
        {
            Console.WriteLine("Your enemies fear you, fighting you is akin to fighting a hoard of enemies.");
        }
        else if (Wave == 9)
        {
            Console.WriteLine("You command your powers with skill, yet you strive for godhood, under the presure of the world you advance to Sequence 4 Bizarro Sorcerer.");
        }
        else if (Wave == 10)
        {
            Console.WriteLine("Your powers are truly bizarre, warping reality to your will.");
        }
        else if (Wave == 11)
        {
            Console.WriteLine("Your hunger for power fuels you, through struggle you advance to Sequence 3 Schollar of Yore, Every action ripples through fate, your insight grows, but so does your burden.");
        }
        else if (Wave == 12)
        {
            Console.WriteLine("Unsatisfied with being a demigod you ascend to Sequence 2 Miracle Invoker.");
        }
        else if (Wave == 13)
        {
            Console.WriteLine("With your power increasing as you advance you yearn to see what true godhood is like. You advance to Sequence 1 Attendant of Mysteries");
        }
        else if (Wave == 14)
        {
            Console.WriteLine("You are near omnipotent, the world trembles yet knows not it is you who shakes it. You pull the string behind the curtain both past and present.");
        }
        else if (Wave == 15)
        {
            Console.WriteLine("Overcome with desire for godhood you decide to advance again, after a intense apotheosis ritual you have finally become a true god, you have become, The Fool");
        }

        PlayerHP = BaseHP;
        MonsterHP = 100 * Wave / 2;
        MonsterMinDMG = MonsterMinDMG * Wave / 2;
        MonsterMaxDMG = MonsterMaxDMG * Wave / 2;
        string[] monsters = { "Curly Haired Baboon", "Amon", "Medici", "Lumian", "Member of Parliament" };
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

                int MonsterDMG = Random.Shared.Next(MonsterMinDMG, MonsterMaxDMG);
                Console.WriteLine("");
                Console.WriteLine($"{monster}'s turn!");
                PlayerHP -= MonsterDMG;
                if (PlayerHP < 0) PlayerHP = 0;
                Console.WriteLine($"{monster} did {MonsterDMG} DMG");
                Console.WriteLine($"{name}'s HP:{PlayerHP}, Monster HP: {MonsterHP}");
                Console.WriteLine("Press a button to continue");
                Console.ReadLine();
                Round++;
            }
            else if (turn > playerhitchance)
            {
                int MonsterDMG = Random.Shared.Next(MonsterMinDMG, MonsterMaxDMG);
                Console.WriteLine($"{monster}'s turn!");
                PlayerHP -= MonsterDMG;
                if (PlayerHP < 0) PlayerHP = 0; //same thing as before (Line 71)
                Console.WriteLine($"{monster} did {MonsterDMG} DMG");
                if (PlayerHP <= 0)
                {
                    Console.WriteLine($"{name} has been defeated!");
                    break;
                }

                int PlayerDMG = Random.Shared.Next(PlayerMinDmg, PlayerMaxDmg);
                Console.WriteLine($"{name}'s turn!");
                MonsterHP -= PlayerDMG;
                if (MonsterHP < 0) MonsterHP = 0; // Prevents hp going under 0
                Console.WriteLine($"{name} did {PlayerDMG} DMG");
                Console.WriteLine($"{name}'s HP:{PlayerHP}, Monster HP: {MonsterHP}");
                Console.WriteLine("Press a button to continue");
                Console.ReadLine();
                Round++;
            }
        }

        Console.WriteLine("Fight over!");
        Console.WriteLine($"Player HP:{PlayerHP}, Monster HP: {MonsterHP}");
        if (PlayerHP >= 0 && MonsterHP == 0)
        {
            Console.WriteLine("You won");
            Wave += 1;
            Gold += 50 * Wave / 2;

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
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Play = false;
    }
}