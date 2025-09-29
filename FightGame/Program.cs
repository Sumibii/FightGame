/*
TODO!
Add crafting,
How: redo how items work, intead of the purchase giving you stats it gives you += 1 to the interger of the item.


 */




string playername = "";

    Console.WriteLine("Welcome to the Fighting Game!");
    Console.WriteLine("What's your name?");
    playername = Console.ReadLine();
bool running = true;
    Console.Title = "Fighting Game";
    int Wave = 1;
    int Gold = 50;
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
        else if (Wave >= 30)
        {
            Console.WriteLine($""" 
        Greetings {playername}!
        Congratulations on becoming a great old one, i have restocked my inventory with the most powerful items just for you.

        You have {Gold} gold

        1. Authority of Space & Time, Increase min/max damage by 250 Costs 15000 Gold 

        2.  Authority of Miracles, Increase HP by 1000. Costs 15000 Gold

        3. King of Space-Time, Set hitchance to 100%. Costs 50000 Gold

        4. Exit shop

        Your current stats: HP:{PlayerHP}, Minimum Damage: {PlayerMinDmg}, Max Damage: {PlayerMaxDmg - 1}, Hitchance(%): {playerhitchance};
        """);
        }
    }
    Console.Clear();

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
        Console.Clear();
        Play = true;
    }


    else if (mainmenu == "2")
    {
        Console.Clear();
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
                Console.Clear();
                Console.WriteLine("\nMutated Sun Sacred Emblem bought! \n");
                PlayerMaxDmg += 5;
                PlayerMinDmg += 5;
                playerhitchance -= 2;
                Gold -= 50;
            }
            else if (itemchoice == "1" && Wave >= 5 && Wave < 10 && Gold >= 150)
            {
                Console.Clear();
                Console.WriteLine("\nBlood Vessel Thief bought!\n");
                PlayerMaxDmg += 10;
                PlayerMinDmg += 10;
                playerhitchance -= 3;
                Gold -= 150;
            }
            else if (itemchoice == "1" && Wave >= 10 && Wave < 15 && Gold >= 450)
            {
                Console.Clear();
                Console.WriteLine("\nSword of the Sun bought!\n");
                PlayerMaxDmg += 20;
                PlayerMinDmg += 20;
                playerhitchance -= 5;
                Gold -= 450;
            }
            else if (itemchoice == "1" && Wave >= 15 && Gold >= 1500)
            {
                Console.Clear();
                Console.WriteLine("\nBook of Calamity bought!\n");
                PlayerMaxDmg += 50;
                PlayerMinDmg += 50;
                playerhitchance -= 6;
                Gold -= 1500;
            }
            else if (itemchoice == "1" && Wave >= 30 && Gold >= 15000)
            {
                Console.Clear();
                Console.WriteLine("\nAuthority of Space-Time bought!\n");
                PlayerMaxDmg += 250;
                PlayerMinDmg += 250;
                Gold -= 15000;
            }
            else if (itemchoice == "2" && Wave < 5 && Gold >= 50)
            {
                Console.Clear();
                Console.WriteLine("\nMisfortune Cloth Puppet bought!\n");
                PlayerMaxDmg -= 3;
                PlayerMinDmg -= 3;
                BaseHP += 25;
                Gold -= 50;
            }
            else if (itemchoice == "2" && Wave >= 5 && Wave < 10 && Gold >= 150)
            {
                Console.Clear();
                Console.WriteLine("\nPrideful Armor bought!\n");
                PlayerMaxDmg -= 5;
                PlayerMinDmg -= 5;
                BaseHP += 50;
                Gold -= 150;
            }
            else if (itemchoice == "2" && Wave >= 10 && Wave < 15 && Gold >= 450)
            {
                Console.Clear();
                Console.WriteLine("\nBerserker's Armor bought!\n");
                PlayerMaxDmg -= 10;
                PlayerMinDmg -= 10;
                BaseHP += 100;
                Gold -= 450;
            }
            else if (itemchoice == "2" && Wave >= 15 && Gold >= 1500)
            {
                Console.Clear();
                Console.WriteLine("\nBlack Emperor's Crown bought!\n");
                PlayerMaxDmg -= 15;
                PlayerMinDmg -= 15;
                BaseHP += 150;
                Gold -= 1500;
            }
            else if (itemchoice == "2" && Wave >= 30 && Gold >= 15000)
            {
                Console.Clear();
                Console.WriteLine("\nAuthority of Miracles bought!\n");
                BaseHP += 1000;
                Gold -= 15000;
            }
            else if (itemchoice == "3" && Wave < 5 && Gold >= 100)
            {
                Console.Clear();
                Console.WriteLine("\nSpirit Medium's Mirror bought!\n");
                playerhitchance += 3;
                BaseHP -= 15;
                Gold -= 100;
                if (playerhitchance > 100)
                {
                    playerhitchance = 100;
                }
            }
            else if (itemchoice == "3" && Wave >= 5 && Wave < 10 && Gold >= 300)
            {
                Console.Clear();
                Console.WriteLine("\nCreeping Hunger bought!\n");
                playerhitchance += 5;
                BaseHP -= 25;
                Gold -= 300;
                if (playerhitchance > 100)
                {
                    playerhitchance = 100;
                }
            }
            else if (itemchoice == "3" && Wave >= 10 && Wave < 15 && Gold >= 900)
            {
                Console.Clear();
                Console.WriteLine("\nEye of Omniscience bought!\n");
                playerhitchance += 7;
                BaseHP -= 50;
                Gold -= 900;
                if (playerhitchance > 100)
                {
                    playerhitchance = 100;
                }
            }
            else if (itemchoice == "3" && Wave >= 15 && Gold >= 3000)
            {
                Console.Clear();
                Console.WriteLine("\nDie of Probability bought!\n");
                playerhitchance += 10;
                BaseHP -= 100;
                Gold -= 3000;
                if (playerhitchance > 100)
                {
                    playerhitchance = 100;
                }
            }
            else if (itemchoice == "3" && Wave >= 30 && Gold >= 15000)
            {
                Console.Clear();
                Console.WriteLine("\nYou have become the King of Space-Time!\n");
                playerhitchance = 100;
                Gold -= 30000;
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
        else if (Wave == 20)
        {
            Console.WriteLine("After spreading your name across the lands the people have started to worship you, your status as a diety has allowed you to learn of a greater power than Sequence 0");
        }
        else if (Wave == 25)
        {
            Console.WriteLine("You have gathered all the ingredients and start your advancement to go beyond the sequences, also know as becoming a great old one");
        }
        else if (Wave == 30)
        {
            Console.WriteLine("After a long battle with the corruption of 'The Oldest One' you advance to become the Lord of The Mysteries.");
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

            int turn = 0;
            turn = Random.Shared.Next(1, 101);


            if (turn <= playerhitchance)
            {
                Console.WriteLine("Player goes first!");
                int PlayerDMG = Random.Shared.Next(PlayerMinDmg, PlayerMaxDmg);
                Console.WriteLine($"{playername}'s turn!");
                MonsterHP -= PlayerDMG;
                if (MonsterHP < 0) MonsterHP = 0;
                Console.WriteLine($"{playername} did {PlayerDMG} DMG");
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
                    Console.WriteLine($"{playername} has been defeated!");
                    break;
                }

                int PlayerDMG = Random.Shared.Next(PlayerMinDmg, PlayerMaxDmg);
                Console.WriteLine($"{playername}'s turn!");
                MonsterHP -= PlayerDMG;
                if (MonsterHP < 0) MonsterHP = 0; // Prevents hp going under 0
                Console.WriteLine($"{playername} did {PlayerDMG} DMG");
                Console.WriteLine($"{playername}'s HP:{PlayerHP}, Monster HP: {MonsterHP}");
                Console.WriteLine("Press a button to continue");
                Console.ReadLine();
                Round++;
            }
        }

        Console.WriteLine("Fight over!");
        Console.WriteLine($"Player HP:{PlayerHP}, Monster HP: {MonsterHP}");
        if (PlayerHP >= 0 && MonsterHP == 0)
        {
            Console.Clear();
            Console.WriteLine("You won");
            Wave += 1;
            Gold += 50 * Wave / 2;

        }
        else if (PlayerHP == 0 && MonsterHP >= 0)
        {
            Console.Clear();
            Console.WriteLine("You loose");
            Console.ReadLine();
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
