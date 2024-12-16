public class LoadGame{
    public void ShowLoadGameMenu(){
        Console.Clear();
        Console.WriteLine("===== Load Game =====");
        Console.WriteLine("[1] Show All Characters");
        Console.WriteLine("[2] View Saved Characters");
        Console.WriteLine("[3] Back to Main Menu");

        int choice = CharacterCreation.GetValidInput("Choose an option: ", 1, 3);

        if(choice == 1){
            ShowAllCharacters();
        }
        else if (choice == 2){
            ViewSavedCharacters();
        }
        else{
            return;
        }
    }

    //Stolen from Kanlaon, the local deity, the Ruler of Time itself!... no big deal
    private void ShowAllCharacters()
    {
        Console.Clear();
        Console.WriteLine("===== All Characters =====");

        List<(int id, string name)> characters = GetAllCharacters();
        if (characters.Count == 0)
        {
            Console.WriteLine("No characters found.");
            return;
        }

        foreach (var character in characters)
        {
            // Fetch detailed information for each character
            string query = $"SELECT * FROM qwertyballsdb.character WHERE id={character.id};";
            using (var reader = DatabaseHelper.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    Console.WriteLine($"Name: {reader["name"]}");
                    Console.WriteLine($"Gender: {reader["gender"]}");
                    Console.WriteLine($"Age: {reader["age"]}");
                    Console.WriteLine($"Body Type: {reader["bodyType"]}");
                    Console.WriteLine($"Height: {reader["height"]}");
                    Console.WriteLine($"Skin Color: {reader["skin"]}");
                    Console.WriteLine($"Hair Type: {reader["hairType"]}");
                    Console.WriteLine($"Hair Color: {reader["hairColor"]}");
                    Console.WriteLine($"Eye Color: {reader["eyeColor"]}");
                    Console.WriteLine($"Headgear: {reader["headgear"]}");
                    Console.WriteLine($"Top: {reader["top"]}");
                    Console.WriteLine($"Pants: {reader["pants"]}");
                    Console.WriteLine($"Shoes: {reader["shoes"]}");
                    Console.WriteLine($"Accessories: {reader["accessories"]}");
                    Console.WriteLine($"Face Paint: {reader["face"]}");
                    Console.WriteLine($"Bat: {reader["bat"]}");
                    Console.WriteLine($"Gloves: {reader["gloves"]}");
                    Console.WriteLine($"Physical Class: {reader["phyClass"]}");
                    Console.WriteLine($"Mental Class: {reader["menClass"]}");
                    Console.WriteLine($"Special Trait: {reader["special"]}");
                    Console.WriteLine($"Team Name: {reader["teamName"]}");
                    Console.WriteLine($"Jersey Number: {reader["teamNumber"]}");
                    Console.WriteLine("----------------------------");
                }
            }
        }

        Console.WriteLine("\nPress any key to return to the Load Game Menu...");
        Console.ReadKey();
        ShowLoadGameMenu();
    }

    private void ViewSavedCharacters()
    {
        Console.Clear();
        Console.WriteLine("===== Saved Characters =====");

        List<(int id, string name)> characters = GetAllCharacters();
        if (characters.Count == 0)
        {
            Console.WriteLine("No saved characters found.");
            return;
        }

        Console.WriteLine("Select a character:");

        for (int i = 0; i < characters.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {characters[i].name}");
        }
        Console.WriteLine($"[{characters.Count + 1}] Back to Main Menu");

        int choice = CharacterCreation.GetValidInput($"Choose a number (1-{characters.Count + 1}): ", 1, characters.Count + 1);
        if (choice == characters.Count + 1) return;

        var selectedCharacter = characters[choice - 1];
        Console.WriteLine($"\nSelected: {selectedCharacter.name}");
        Console.WriteLine("[1] View Character Details");
        Console.WriteLine("[2] Delete Character");
        Console.WriteLine("[3] Back to Load Game Menu");

        int action = CharacterCreation.GetValidInput("Choose an option: ", 1, 3);
        if (action == 1)
        {
            DisplayCharacterDetails(selectedCharacter.id);
        }
        else if (action == 2)
        {
            //Console.Clear();
            Console.WriteLine("Are you sure you want to delete this character?\n[1] Yes\n[2] No");
            int deleteConfirmation = CharacterCreation.GetValidInput("Choose an option: ", 1, 2);
            if (deleteConfirmation == 1){
                DeleteCharacter(selectedCharacter.id);
            }
            else if(deleteConfirmation == 2){
                Console.WriteLine("\nCharacter was NOT deleted.");
            }
        }
        else
        {
            ShowLoadGameMenu();
        }
    }

    private List<(int id, string name)> GetAllCharacters()
    {
        string query = "SELECT id, name FROM qwertyballsdb.character;";
        var characters = new List<(int id, string name)>();

        using (var reader = DatabaseHelper.ExecuteReader(query))
        {
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                characters.Add((id, name));
            }
        }

        return characters;
    }

    private void DisplayCharacterDetails(int characterId)
    {
        string query = $"SELECT * FROM qwertyballsdb.character WHERE id={characterId};";
        using (var reader = DatabaseHelper.ExecuteReader(query))
        {
            if (reader.Read())
            {
                Console.Clear();
                Console.WriteLine("===== Character Details =====");
                Console.WriteLine($"Name: {reader["name"]}");
                Console.WriteLine($"Gender: {reader["gender"]}");
                Console.WriteLine($"Age: {reader["age"]}");
                Console.WriteLine($"Body Type: {reader["bodyType"]}");
                Console.WriteLine($"Height: {reader["height"]}");
                Console.WriteLine($"Skin Color: {reader["skin"]}");
                Console.WriteLine($"Hair Type: {reader["hairType"]}");
                Console.WriteLine($"Hair Color: {reader["hairColor"]}");
                Console.WriteLine($"Eye Color: {reader["eyeColor"]}");
                Console.WriteLine($"Headgear: {reader["headgear"]}");
                Console.WriteLine($"Top: {reader["top"]}");
                Console.WriteLine($"Pants: {reader["pants"]}");
                Console.WriteLine($"Shoes: {reader["shoes"]}");
                Console.WriteLine($"Accessories: {reader["accessories"]}");
                Console.WriteLine($"Face Paint: {reader["face"]}");
                Console.WriteLine($"Bat: {reader["bat"]}");
                Console.WriteLine($"Gloves: {reader["gloves"]}");
                Console.WriteLine($"Physical Class: {reader["phyClass"]}");
                Console.WriteLine($"Mental Class: {reader["menClass"]}");
                Console.WriteLine($"Special Trait: {reader["special"]}");
                Console.WriteLine($"Team Name: {reader["teamName"]}");
                Console.WriteLine($"Jersey Number: {reader["teamNumber"]}");
                Console.WriteLine("\nPress any key to return to the Load Game Menu...");
                Console.ReadKey();
            }
        }
        ShowLoadGameMenu();
    }

    private void DeleteCharacter(int characterId)
    {
        string query = $"DELETE FROM qwertyballsdb.character WHERE id={characterId};";
        int result = DatabaseHelper.ExecuteQuery(query);
        Console.WriteLine(result > 0 ? "\nCharacter deleted successfully!" : "\nFailed to delete character.");
    }
}