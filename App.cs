using System;
using System.Collections.Generic;
using Golf.Interfaces;
using Golf.ModelsActual;

namespace Golf
{
    public class App : IApp
    {
        public Course ActiveCourse { get; set; }
        public List<Player> Players { get; set; }
        public List<Course> Courses { get; set; }
        public bool InChoosingCourses { get; set; }

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

                        // NOTE Still need to figure out how to handle Player
                        Player player = new Player(playerName);
                        Players.Add(player);
                    }

                    playersEntered = true;
                }
            }

            PlayHoles(Players);
        }

        public void PlayHoles(List<Player> Players)
        {
            Console.Clear();
            Console.WriteLine(ActiveCourse.Name);
            Console.WriteLine("================================================");

            // NOTE Keep active hole number displayed while each player enters number of strokes
            // Go through each player. Once all players have entered score move to the next hole.
            // Use Player.ScoreCount()?

            int holeCount = 1;
            // Take this out later
            Console.WriteLine(ActiveCourse.Holes.Count);
            // NOTE Not showing Par number
            Console.WriteLine($"Hole: {holeCount} Par: {ActiveCourse.Holes}");
            Console.WriteLine("------------------------------------------------");
            for (var i = 0; i <= ActiveCourse.Holes.Count; i++)
            {
                Console.Write($"Strokes for {Players[i].Name}: ");
                int numberOfStrokes = Convert.ToInt32(Console.ReadLine());
                // Player[i].ScoreCount(numberOfStrokes);
            }

            DisplayPlayerResults();
        }

        public void Run()
        {
            while (InChoosingCourses)
            {
                DisplayCourses();
            }
        }

        public void DisplayPlayerResults()
        {
            Console.WriteLine(ActiveCourse.Name);
            Console.WriteLine("Total Player Scores");
            Console.WriteLine("------------------------------------------------");

            for (var i = 0; i < Players.Count; i++)
            {
                // NOTE Display player name and score total use Player.ScoreCount();
                // Console.WriteLine(Player.);
            }
        }

        public App()
        {
            InChoosingCourses = true;
            Players = new List<Player>();
            Courses = new List<Course>();
        }
    }
}