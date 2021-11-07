using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CircleLab
{
    class Circle
    {
        public double Radius { get; set; }
        

        public Circle (double Radius)
        {
            this.Radius = Radius;
            
        }

        public double CalculateCircumference 
        {
            get 
             {

                return Math.Round(2 * Math.PI * Radius, 2); 

            }

        }

        public double CalculateArea
        {
            get
            {
                return Math.Round(Math.PI * Radius * Radius, 2); 
            }
        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }

        public bool Continue()
        {

            string answer = GetUserInput("Would you like to continue? y/n");
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                // This is recursion, calling a method inside itself
                return Continue();
            }

        }
        }
    }


            // Misc Notes: 


            //double radius;
            //double PI = 3.142;
            //double Cir, dia;
            //Console.WriteLine("Enter the Radius of the Circle");
            //radius = double.Parse(Console.ReadLine());
            //Cir = 2 * PI * radius;
            //dia = 2 * PI;
            //return $"The circumfernce is {Cir} and diameter is {dia}";