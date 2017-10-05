using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHomeworkWeek2Day3
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Please enter a name.");
            //string name = Console.ReadLine();

            //Console.WriteLine("Please enter a food.");
            //string food = Console.ReadLine();

            //Favoritefood(name, food);
            //Favoritefood("Bob", "cheese");
            //Favoritefood("Mia", "Mitchell's");
            //Favoritefood("Tom", "bourbon");

            //Console.WriteLine("Please enter your age.");
            //int age = int.Parse(Console.ReadLine());
            //RetirementCalc(age);


            //Console.WriteLine("Please enter how many hours you worked.");
            //double hoursWorked = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter your hourly wage.");
            //double wage = double.Parse(Console.ReadLine());

            //WageCalc(hoursWorked, wage);

            Console.WriteLine("How many different blocks of cheese have you seen Dan Brooks consume?");
            int blocksOfCheese = int.Parse(Console.ReadLine());

            Console.WriteLine("How much did each block of cheese weigh (oz), in integer form, with no special characters?");
            int weightOfCheese = int.Parse(Console.ReadLine());

            HowMuchCheese(blocksOfCheese, weightOfCheese);
        }

        public static double WageCalc(double hoursWorked, double wage)
        { double monthlyWage = hoursWorked * wage;
            Console.WriteLine("Your monthly wage is $" +monthlyWage+ ".");
            return monthlyWage;
        }

        public static int HowMuchCheese(int blocksOfCheese, int weightOfCheese)
        { int howMuchCheese = blocksOfCheese * weightOfCheese;
            Console.WriteLine("Dan Brooks ate " + howMuchCheese + " oz of cheese... when we were looking.");
            return howMuchCheese;
        }

        public static string WhatDadSaid(string words, string day)
        {
            string dadTracker = "We heard dad say " + words + " on " + day + ".";
            Console.WriteLine(dadTracker);
            return dadTracker;
            }

        public static void Favoritefood(string personName, string food)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(personName + " loves " + food +"!");
            Console.WriteLine(" ");
        }

        public static void RetirementCalc(int age)
        {
            //age = int.Parse(Console.ReadLine());
            int yearsUntil = Math.Max(0, 65 - age);
            Console.WriteLine("You have " + yearsUntil + " years until you retire!");

        }

    }

    }

