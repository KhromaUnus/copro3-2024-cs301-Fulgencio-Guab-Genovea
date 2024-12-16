struct CampaignMode{
    // [TEMPORARY SOLUTION UNTIL DATABASE USE IS FIGURED OUT]
    public void StorySummary(){
        Console.Clear();
        Console.WriteLine("===== Campaign Story Summary =====\n");

        Console.WriteLine(
        $"In a small barangay located somewhere in the Philippines, baseball was more than just some foreign sport—it was the passion of the community. " +
        $"Every\nyear, the barangay rallied behind their pride and joy, the \"STI Bawlers\", an amateur team fighting to reach the pro leagues of MLG. " +
        $"You, a promising\nbaseball player, had grown up idolizing the MLG Players such as Steven Curry and Alex Jorgan. " +
        $"Your gay father, a former pro player, had taught you\nthe importance of heart over talent, something you carried with you as you stepped into the batter's box from your first game, all the way to now. " +
        $"\nBut after your gay father and his fellow gay, bi, trans, attack helicopter and etc-gendered players retired, their team, \"Jared's Angels\" lost it's\nspark and on the brink of collapse, with dwindling funds and with only one way to save the team: Merging with a younger, passion-driven team—one\nsuch as your own. " +
        $"\nAs time progressed, it became clear that near-collpase Jared's Angels were not just the result of loss of talent but also because it's current members\nwere not just fighting other teams but also their own demons. " +
        $"The star pitcher, Ungoy D. Yuffie, was battling his constantly changing sexual preferences—\nindecisive of whether it wanted to be a transformer or a frying pan, while the team's veteran manager, Coach Navales, seemed haunted by ghosts of past\nfailures—most importantly, his failure to get his K-Pop Idol's autograph. " +
        $"Despite this though, after the merging of both teams, you emerged as the\nleader, uniting the team with a mix of grit, charisma and marijuana—leading them to the City Championship. " +
        $"Each game was a test of skill and determination,\nwith rivals like MLG pro league team of Navotas called \'Berifco Votas-Votas\' pushing you and your team to the limit. " +
        $"Off the field, your home-barangay\nwas fully believing with both a sense of pride and exhiliration, filling the stadium with cheers that echoed like they had decades ago for Jared's Angels.\n" +
        $"But beneath the surface, the pressure mounted as rumors swirled that the championship game would determine whether their barangay would once again taste\nglory and hold the cup of victory." +
        $"\nOn the even of the championship, a storm rolled in, mirroring the tension in the locker room. " +
        $"The final game was against Valenzuela's \"Digmaang Thunder\nBoys\", an undefeated pro team said to be guided by their local god, Kanlaon—they notorious for crushing opponents, sweeping across the regionals and\nnationals when they started a couple years ago. " +
        $"As the game unfolded, it became a nail-biting contest of strategy, perserverance, and douchbaggery. " +
        $"\nIn the ninth inning, with two outs and bases loaded, the spotlight fell on you. " +
        $"Every lesson your gay father taught you and every sacrifice your teammates made\nbrought you to this moment. " +
        $"With the weight of your barangay resting upon your shoulders, using special move that you developed through the years, you\nswung your bat for a legacy. " +
        $"The crack of the bat echoed like thunder, and as the ball soared, so too did the hopes of everyone that believed in you."
        );
    }

    /* [CANCELLED DUE TO DEADLINE]
        TODO:
        -Prologue
        -Episode 1-3
        -Epilogue
    */

    public void StartCampaign(int chapter){
        Console.Clear();
        Console.WriteLine($"===== Campaign Mode (Starting at Chapter {chapter}) =====");

        switch(chapter){
            case 1:
                PlayPrologue();
                break;
            case 2:
                PlayEpisode1();
                break;
            /*case 3:
                PlayEpisode2();
                break;
            case 4:
                PlayEpisode3();
                break;
            case 5:
                PlayEpilogue();
                break;*/
            default:
                Console.WriteLine("Chapter not implemented yet.");
                break;
        }
    }

    private void PlayPrologue(){
        Console.Clear();
        Console.WriteLine("===== Chapter: Prologue =====");

        string[] Prologue = {
            "In a small barangay somewhere in the Philippines, there was a place where dreams were as big as the sky and, unfortunately, as fragile as the bamboo stands that lined the outskirts of town.\n",
            "Baseball, that strange foreign game with a bat and a ball, had somehow wormed its way into the heart of the community.\n",
            "It wasn't the national sport, not by a long shot, but here it was more important than a mayoral election or even a town fiesta.\n",
            "Why? ",
            "Because the STI Ballers were more than a team—they were the very pulse of the barangay.",
            "\nYou grew up in the shadow of these legends. ",
            "",
        };

        PlayText(Prologue);

        PlayEpisode1();
    }

    private void PlayEpisode1(){
        Console.Clear();

        /*
            Episode 1
        */
    }

    private void PlayText(string[] SiMhartSupot){
        try{
            //Threads to play text letter by letter, technically works*
            for(int i = 0; i <= SiMhartSupot.Length; i++){
                foreach(char c in SiMhartSupot[i]){
                    Thread.Sleep(30);
                    Console.Write(c);
                }
                Console.ReadKey();
            }
        }
        catch(IndexOutOfRangeException E){}
    }
}