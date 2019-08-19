using System;
using System.Collections.Generic;
using System.Linq;
using Golf.Interfaces;
using Golf.ModelsActual;

namespace Golf
{
    public class App : IApp
    {
        public Course ActiveCourse { get; set; }
        public List<Player> Players { get; set; }
        public List<Course> Courses { get; set; }
        // public bool InChoosingCourses { get; set; }

        public void Setup()
        {
            Hole hole3 = new Hole(3);
            Hole hole4 = new Hole(4);
            Hole hole5 = new Hole(5);
            Hole hole6 = new Hole(6);

            Course course1 = new Course("Toad Highlands");
            Course course2 = new Course("Shy Guy Desert");
            Course course3 = new Course("Koopa Park");

            course1.Holes.Add(hole5);
            course1.Holes.Add(hole3);
            course1.Holes.Add(hole4);
            course1.Holes.Add(hole6);

            course2.Holes.Add(hole5);
            course2.Holes.Add(hole3);
            course2.Holes.Add(hole4);
            course2.Holes.Add(hole6);

            course3.Holes.Add(hole5);
            course3.Holes.Add(hole3);
            course3.Holes.Add(hole4);
            course3.Holes.Add(hole6);

            Courses.Add(course1);
            Courses.Add(course2);
            Courses.Add(course3);
        }
        public void Greeting()
        {

        }

        public void DisplayCourses()
        {
            Console.WriteLine("MARIO GOLF!");
            Console.WriteLine("================================================");

            int count = 1;
            foreach (var course in Courses)
            {
                Console.WriteLine($"{count}. {course.Name}");
                count++;
            }
            Console.WriteLine("------------------------------------------------");

            SelectCourse();
        }

        public void SelectCourse()
        {
            Console.Write("Choose a Course: ");
            string courseChoice = Console.ReadLine();
            switch (courseChoice)
            {
                case "1":
                    ActiveCourse = Courses[0];
                    break;
                case "2":
                    ActiveCourse = Courses[1];
                    break;
                case "3":
                    ActiveCourse = Courses[2];
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    SelectCourse();
                    break;
            }

            SetPlayers();
        }

        public void SetPlayers()
        {
            Console.Write("Enter number of players: ");
            int numberOfPlayers;
            bool playersEntered = false;

            while (!playersEntered)
            {
                playersEntered = Int32.TryParse(Console.ReadLine(), out numberOfPlayers);
                if (!playersEntered)
                {
                    Console.WriteLine("Invalid Entry!");
                    Console.Write("Please enter a number for the number of players: ");
                    continue;
                }

                if (playersEntered)
                {
                    while (numberOfPlayers > 0)
                    {
                        numberOfPlayers--;
                        Console.Write("Player Name: ");
                        string playerName = Console.ReadLine();

                        Player player = new Player(playerName);
                        Players.Add(player);
                    }

                    playersEntered = true;
                }
            }
        }

        public void Run()
        {
            DisplayCourses();

            Console.Clear();
            int holeCount = 1;
            // NOTE Not showing Par number
            for (var i = 0; i < ActiveCourse.Holes.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(ActiveCourse.Name);
                Console.WriteLine("================================================");
                Console.WriteLine($"Hole: {holeCount}");
                Console.WriteLine("------------------------------------------------");

                // NOTE Doesn't handle non ints well. Super gross type checking. Feel like I'm close to making it work...
                int numberOfStrokes = 0;
                bool strokesEntered = false;
                while (!strokesEntered)
                {
                    for (var p = 0; p < Players.Count; p++)
                    {
                        Console.Write($"Strokes for {Players[p].Name}: ");
                        strokesEntered = Int32.TryParse(Console.ReadLine(), out numberOfStrokes);
                        if (!strokesEntered)
                        {
                            Console.WriteLine("Invalid Entry!");
                            Console.WriteLine("Please enter a number for the number of strokes.");
                            break;
                        }
                        if (strokesEntered)
                        {
                            Players[p].Scores.Add(numberOfStrokes);
                            strokesEntered = true;
                        }
                    }
                }
                // NOTE Need to handle if not an int
                // for (var p = 0; p < Players.Count; p++)
                // {
                //     Console.Write($"Strokes for {Players[p].Name}: ");
                //     int numberOfStrokes = Convert.ToInt32(Console.ReadLine());
                //     Players[p].Scores.Add(numberOfStrokes);
                // }

                holeCount++;
            }

            DisplayPlayerResults();

            Console.WriteLine("");
            Console.WriteLine("Press (Q) to quit or any other key to create a new game.");

            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Q")
            {
                return;
            }
            if (userInput != "Q")
            {
                Console.Clear();
                Run();
            }
        }

        public void DisplayPlayerResults()
        {
            // NOTE Stretch: Display course holes par, display each player scores per hole
            // NOTE Stretch: Display Course total par
            // NOTE Display winner (lowest score)
            // NOTE Option to Quit or play another game

            Console.Clear();
            Console.WriteLine(ActiveCourse.Name);
            Console.WriteLine("================================================");
            Console.WriteLine("Total Player Scores");
            Console.WriteLine("------------------------------------------------");

            foreach (var player in Players)
            {
                Console.Write(player.Name + ": ");
                Console.WriteLine(player.DisplayFinalScore());
            }

            DisplayWinner();
        }

        // NOTE Still doesn't display the correct winner
        public void DisplayWinner()
        {
            string winner = "";
            int lowestTotalScore = Players[0].TotalScore;
            Console.WriteLine("");

            // NOTE Doesn't work since winner gets re-written every time.
            //      Needs to compare to other player totalscores but unsure how to do that.
            for (var i = 0; i < Players.Count; i++)
            {
                int currentScore = Players[i].TotalScore;
                if (currentScore < lowestTotalScore)
                {
                    lowestTotalScore = currentScore;
                }
                if (lowestTotalScore == Players[i].TotalScore)
                {
                    winner = Players[i].Name;
                }
            }

            Console.WriteLine("The Winner: " + winner);
            Console.WriteLine("================================================");
        }

        public App()
        {
            // InChoosingCourses = true;
            Players = new List<Player>();
            Courses = new List<Course>();
        }
    }
}