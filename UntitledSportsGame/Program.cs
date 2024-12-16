namespace qwertyBalls{ //qwerty stands for "idk what to name this yet" and Balls stands for "bruh"
    public class Program{
        public static void Main(string[] args){
            bool willToLive = true;

            //Main Menu
            while(willToLive){
                Console.Clear();
                Console.WriteLine("===== MLG Samson Balls: Origins =====");
                Console.WriteLine("[1] New Game");
                Console.WriteLine("[2] Load Game");
                Console.WriteLine("[3] Campaign Mode");
                Console.WriteLine("[4] Credits");
                Console.WriteLine("[5] Exit\n");
                Console.Write("Select an option: ");

                switch(Console.ReadLine()){
                    case "1":
                        StartNewGame();
                        break;
                    case "2":
                        LoadGame();
                        break;
                    case "3":
                        CampaignMode();
                        break;
                    case "4":
                        ShowCredits();
                        break;
                    case "5":
                        willToLive = false;
                        Console.WriteLine("\nGoodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }

                if(willToLive){
                    Console.Write("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        static void StartNewGame(){
            NewGame NuGame = new CharacterCreation();
            NuGame.CharacterCustomization();
        }

        static void LoadGame(){
            LoadGame LudDaGame = new LoadGame();
            LudDaGame.ShowLoadGameMenu();
        }

        static void CampaignMode(){
            CampaignMode ToweeMODE = new CampaignMode();
            ToweeMODE.StorySummary();
        }

        static void ShowCredits(){
            Console.Clear();
            Console.WriteLine("===== Credits =====");
            Console.WriteLine("Developed by \"MaNa Gang\" Game Studios:");
            Console.WriteLine("Fulgenco, Charle Dizon");
            Console.WriteLine("Guab, Lance Karyll Lumba");
            Console.WriteLine("Genovea, Aira Mae Baldismo");
        }
    }
}