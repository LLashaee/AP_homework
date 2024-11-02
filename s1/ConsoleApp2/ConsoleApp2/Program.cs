using System;

namespace DecisionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Decision Tree!");
            Step1();
        }

        static void Step1()
        {
            Console.WriteLine("Question 1: Are you interested in programming? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Step2A();
            }
            else if (answer == "no")
            {
                Step2B();
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step1();
            }
        }

        static void Step2A()
        {
            Console.WriteLine("Question 2: Do you have programming experience? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Step3A();
            }
            else if (answer == "no")
            {
                Step3B();
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step2A();
            }
        }

        static void Step2B()
        {
            Console.WriteLine("Question 2: Are you interested in learning? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Step3C();
            }
            else if (answer == "no")
            {
                Console.WriteLine("You may need more motivation to start learning.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step2B();
            }
        }

        static void Step3A()
        {
            Console.WriteLine("Question 3: Have you worked on practical projects? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Step4A();
            }
            else if (answer == "no")
            {
                Step4B();
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step3A();
            }
        }

        static void Step3B()
        {
            Console.WriteLine("Question 3: Are you interested in learning programming basics? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Step4C();
            }
            else if (answer == "no")
            {
                Console.WriteLine("Programming might not be the right field for you.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step3B();
            }
        }

        static void Step3C()
        {
            Console.WriteLine("Question 3: Are you interested in learning other skills? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Step4D();
            }
            else if (answer == "no")
            {
                Console.WriteLine("It might be good to find new interests to pursue.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step3C();
            }
        }

        static void Step4A()
        {
            Console.WriteLine("Question 4: Are you interested in advanced topics like algorithms or data structures? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Great! You are ready to dive into advanced programming topics.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Consider exploring more intermediate projects first.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step4A();
            }
        }

        static void Step4B()
        {
            Console.WriteLine("Question 4: Would you like to start a small project to practice? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("That's a good step! Start with a small project to build experience.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("It might be beneficial to revisit the basics and try again.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step4B();
            }
        }

        static void Step4C()
        {
            Console.WriteLine("Question 4: Would you like to learn with tutorials or in a course? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Perfect! There are many online resources to get started.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("You might consider self-study using online documentation and practice.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step4C();
            }
        }

        static void Step4D()
        {
            Console.WriteLine("Question 4: Are you open to exploring a completely new field of study? (yes/no)");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("That's wonderful! You can start exploring new skills and interests.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Finding something specific to focus on can be very rewarding.");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                Step4D();
            }
        }
    }
}
