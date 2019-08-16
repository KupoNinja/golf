using System;
using System.Collections.Generic;
using Golf.Interfaces;
using Golf.Models;

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

            Courses.Add(course1);
            Courses.Add(course2);
            Courses.Add(course3);
        }
        public void Greeting()
        {

        }

        public void DisplayCourses()
        {
            Console.WriteLine("MARIO Golf!");
            Console.WriteLine("================================================");

            int count = 1;
            foreach (var course in Courses)
            {
                Console.WriteLine($"{count}. {course.Name}");
                count++;
            }
            Console.WriteLine("------------------------------------------------");

            SelectCourse();
            SetPlayers();
        }

        public void SelectCourse()
        {
            // Console.WriteLine("Choose a course:");
            // string courseChoice = Console.ReadLine();
            // switch (courseChoice)
            // {
            //     case "1":

            //     default:
            // }
        }

        public void SetPlayers()
        {

            Console.WriteLine("Number of Players:");

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

        }

        public App()
        {
            Players = new List<Player>();
            Courses = new List<Course>();
        }
    }
}