using System.Text.RegularExpressions;

class CharacterCreation : BaseCharacter, NewGame{
    public override void CharacterCustomization(){
        Console.Clear();
        Console.WriteLine("===== New Game =====");

        /* Customization Options
        / Character Info */
        this.Name = GetValidInput("----- Character Info -----\nEnter your character's name (8-28, no numbers, no special characters): ", @"^[a-zA-Z\s]{8,28}$");
        //Check if the name is already taken
        while(IsCharacterNameTaken(this.Name)){
            Console.WriteLine("Character name already taken. Please choose a different name.");
            this.Name = GetValidInput("Enter your character's name (8-28, no numbers, no special characters): ", @"^[a-zA-Z\s]{8,28}$");
        }
        this.Gender = GetValidInput("[1] Male\n[2] Female\n[3] Hideyoshi\nChoose your character's gender: ", new string[] { "Male", "Female", "Hideyoshi" });
        this.Age = GetValidInput("[1] Prodigy\n[2] Young Adult\n[3] Adult\n[4] Senior\n[5] Legendary\nChoose your character's age: ", new string[] { "Prodigy", "Young Adult", "Adult", "Senior", "Legendary" });

        //Physical Appearance
        this.BodyType = GetValidInput("\n----- Physical Appearance -----\n[1] Ectomorph\n[2] Endomorph\n[3] Mesomorph\n[4] Shrek\nChoose Body Type: ", new string[] { "Ectomorph", "Endomorph", "Mesomorph", "Shrek" });
        this.Height = GetValidInput("[1] Kapre (Extremely Tall)\n[2] Tall\n[3] Average\n[4] Short\n[5] Midget\nChoose Height: ", new string[] { "Kapre", "Tall", "Average", "Short", "Midget" });
        this.SkinColor = GetValidInput("[1] Black\n[2] Brown\n[3] Tan\n[4] Yellow\n[5] White\n[6] Blue\n[7] Green\nChoose Skin Color: ", new string[] { "Black", "Brown", "Tan", "Yellow", "White", "Blue", "Green" });
        this.HairType = GetValidInput("[1] Long\n[2] Medium\n[3] Short\n[4] Buzz\n[5] Bald\n[6] Balding\nChoose Hair Type: ", new string[] { "Long", "Medium", "Short", "Buzz", "Bald", "Balding" });
        this.HairColor = GetValidInput("[1] Black\n[2] Brunette\n[3] Blond\n[4] Gray\n[5] White\n[6] Red\n[7] Green\n[8] Blue\n[9] Purple\n[10] Yellow\n[11] Pink\n[12] Rainbow\nChoose Hair Color: ", new string[] { "Black", "Brunette", "Blond", "Gray", "White", "Red", "Green", "Blue", "Purple", "Yellow", "Pink", "Rainbow" });
        this.EyeColor = GetValidInput("[1] Amber\n[2] Black\n[3] Brown\n[4] Hazel\n[5] Blue\n[6] Green\n[7] Purple\nChoose Eye Color: ", new string[] { "Amber", "Black", "Brown", "Hazel", "Blue", "Green", "Purple" });

        //Apparel and Equipment
        this.Headgear = GetValidInput("\n----- Apparel and Equipment -----\n[1] Batting Helmet\n[2] Catcher Mask\n[3] Field Cap\n[4] Chicken Mascot Mask\n[5] Horse Mascot Mask\n[6] Fish-man Manager Mask\n[7] Cowboy Hat\n[8] Green Space Helmet\nChoose Headgear: ", new string[] { "Batting Helmet", "Catcher Mask", "Field Cap", "Chicken Mascot Mask", "Horse Mascot Mask", "Fish-man Manager Mask", "Cowboy Hat", "Green Space Helmet" });
        this.Top = GetValidInput("[1] Black Jersey\n[2] White Jersey\n[3] Striped Jersey\n[4] Chicken Mascot Top\n[5] Horse Mascot Top\n[6] Fish-man Manager Top\n[7] Yellow and Cowskin Cowboy Top\n[8] Green Space Suit\nChoose Top: ", new string[] { "Black Jersey", "White Jersey", "Striped Jersey", "Chicken Mascot Top", "Horse Mascot Top", "Fish-man Manager Top", "Yellow and Cowskin Cowboy Top", "Green Space Suit" });
        this.Pants = GetValidInput("[1] Black Pants\n[2] White Pants\n[3] Striped Pants\n[4] Chicken Mascot Pants\n[5] Horse Mascot Pants\n[6] Cowboy Pants\n[7] White Space Pants\nChoose Pants: ", new string[] { "Black Pants", "White Pants", "Striped Pants", "Chicken Mascot Pants", "Horse Mascot Pants", "Cowboy Pants", "White Space Pants" });
        this.Shoes = GetValidInput("[1] Baseball Shoes\n[2] Running Shoes\n[3] Bjorgan Sneakers\n[4] Sandals\n[5] Mascot Chicken Feet\n[6] Cowboy Boots\n[7] White Space Boots\nChoose Shoes: ", new string[] { "Baseball Shoes", "Running Shoes", "Bjorgan Sneakers", "Sandals", "Mascot Chicken Feet", "Cowboy Boots", "White Space Boots" });
        this.Accessories = GetValidInput("[1] Piercing\n[2] Rapper Chains\n[3] Sunglasses\n[4] Reading Glasses\n[5] Horns\n[6] Cowboy Badge\n[7] Sci-fi Hand Blaster\nChoose Accessories: ", new string[] { "Piercing", "Rapper Chains", "Sunglasses", "Reading Glasses", "Horns", "Cowboy Badge", "Sci-fi Hand Blaster" });
        this.FacePaint = GetValidInput("[1] Yes\n[2] No\nWear Face Paint?: ");
        this.Bat = GetValidInput("[1] Wood Bat\n[2] Metal Bat\n[3] Plastic Bat\n[4] Glow in the Dark Bat\nChoose Baseball Bat: ", new string[] { "Wood Bat", "Metal Bat", "Plastic Bat", "Glow in the Dark Bat" });
        this.Gloves = GetValidInput("[1] Normal Glove\n[2] Dad's Glove\n[3] Vintage Glove\n[4] Glow in the Dark Glove\nChoose Pitching Glove: ", new string[] { "Normal Glove", "Dad's Glove", "Vintage Glove", "Glow in the Dark Glove" });
        
        //Classes and Special Trait
        this.PhysicalClass = GetValidInput("\n----- Classes and Special Trait -----\n[1] Speedster: A High Speed but Low Power Class.\n[2] Slugger: A Low Speed but High Power Class.\n[3] Sisyphus: A High Stamina but Low Accuracy Class.\n[4] Precision Hitter: A High Accuracy but low Stamina Class.\n[5] All-Rounder: All stats balanced evenly, perfect for beginners.\nChoose Physical Class: ", 
                                            new string[] { "Speedster", "Slugger", "Sisyphus", "Precision Hitter", "All-Rounder" });
        this.MentalClass = GetValidInput("[1] Prodigy: Small increase to all stats.\n[2] Ace: Increases odds of success when losing.\n[3] Hot-Head: Increases Power after a miss.\n[4] Playmaker: Grants a 50% chance to clear Special Cooldown.\n[5] Deadeye: Grants a 10% chance for a guaranteed pitch/swing.\nChoose Mental Class: ", 
                                            new string[] { "Prodigy", "Ace", "Hot-Head", "Playmaker", "Deadeye" });
        this.SpecialTrait = GetValidInput("[1] Power Surge: Temporarily increase Power.\n[2] Speed Demon: Temporarily increase Speed.\n[3] Iron Will: Temporarily increase Stamina.\n[4] In the Zone: Temporarily increase Accuracy.\n[5] Stealth Runner: Stealthily steal an opponent's base. (+1 team point, basically)\n[6] Cry a Foul: Be a crybaby! 25% chance to skip the round.\n[7] Chaos: Mystery Special Ability.\nChoose Special Trait: ", 
                                            new string[] { "Power Surge", "Speed Demon", "Iron Will", "In the Zone", "Stealth Runner", "Cry a Foul", "Chaos" });
        
        //Team
        this.TeamName = GetValidInput("\n----- Team -----\nEnter your team name (4-18, numbers allowed, no special characters): ", @"^[a-zA-Z0-9\s]{4,18}$");
        this.JerseyNumber = GetValidInput("Enter your jersey number (1-99): ", 1, 99);

        //Calls function that saves character data to database
        SaveCharacterToDatabase();

        //New Character Showcase
        ShowcaseCharacterInfo();
    }

    public override void ShowcaseCharacterInfo(){
        base.ShowcaseCharacterInfo();
    }

    /*  Overloaded Methods  */
    //String Input
    private static string GetValidInput(string prompt, string restrictions){
        string input;
        while (true){
            Console.WriteLine(prompt);
            input = Console.ReadLine();

            //This code that's totally mine is absolutely BEAUTIFUL...
            if(Regex.IsMatch(input /* ...except for this, dafuq? */, restrictions) && !string.IsNullOrWhiteSpace(input)){
                return input;
            }
        }
    }

    //Multiple Choice
    private static string GetValidInput(string prompt, string[] options){
        string input;
        while (true){
            Console.Write(prompt);
            input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= options.Length){
                return options[choice - 1];
            }

            Console.WriteLine("Invalid choice! Please try again.");
            Console.ReadKey();
        }
    }

    //Int Input
    public static int GetValidInput(string prompt, int min, int max){
        int input;
        while (true){
            try{
                Console.Write(prompt);
                input = int.Parse(Console.ReadLine());

                if (input >= min && input <= max){
                    return input;
                }

                Console.WriteLine($"Invalid input! Please enter a number between {min}-{max}.");
                Console.ReadKey();
            }
            catch (Exception E){
                Console.WriteLine($"Error from user stupidity: {E.Message}");
            }
        }
    }

    //Bool Input
    private static bool GetValidInput(string prompt){
        string input;
        while (true){
            Console.Write(prompt);
            input = Console.ReadLine();

            if (input == "1"){
                return true;
            }
            else if (input == "2"){
                return false;
            }

            Console.WriteLine("Invalid input! Please enter 1 (True) or 2 (False).");
        }
    }

    private bool IsCharacterNameTaken(string name)
    {
        string query = $@"
            SELECT COUNT(*) FROM `qwertyballsdb`.`character` 
            WHERE `name` = '{name}'";

        // Use Convert.ToInt32 to cast the object returned by ExecuteScalarQuery to int
        int result = Convert.ToInt32(DatabaseHelper.ExecuteScalarQuery(query));

        return result > 0;  // If count is greater than 0, the name is taken
    }
        
    //Yeets character data to database
    private void SaveCharacterToDatabase()
    {
        string query = @"
            INSERT INTO `qwertyballsdb`.`character` 
            (`name`, `gender`, `age`, `bodyType`, `height`, `skin`, `hairType`, 
             `hairColor`, `eyeColor`, `headgear`, `top`, `pants`, `shoes`, `accessories`, 
             `face`, `bat`, `gloves`, `phyClass`, `menClass`, `special`, `teamName`, 
             `teamNumber`) 
            VALUES 
            ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', 
             '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', 
             {14}, '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', {21})";

        // Use string formatting for values
        query = string.Format(query,
            DatabaseHelper.EscapeApostrophes(Name), 
            Gender, 
            Age, 
            BodyType, 
            Height, 
            SkinColor, 
            HairType,
            HairColor, 
            EyeColor, 
            Headgear, 
            Top, 
            Pants, 
            Shoes, 
            Accessories,
            FacePaint ? 1 : 0, 
            Bat, 
            Gloves, 
            PhysicalClass, 
            MentalClass, 
            SpecialTrait, 
            TeamName, 
            JerseyNumber
        );

        // Execute the query
        int result = DatabaseHelper.ExecuteQuery(query);
        Console.WriteLine(result > 0 ? "Character saved successfully!" : "Failed to save character.");
    }
}