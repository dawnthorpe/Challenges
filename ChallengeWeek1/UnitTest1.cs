﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeWeek1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Dawn";
            string lastName = "Muldrow";
            int age = 50;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age % 7);

        }

        [TestMethod]
        public void Array()

        {
            string[] movie1 = { "Hidden Figures", "Black Panther", "Girls Trip", "Malcolm X" };
        }

        [TestMethod]

        public void CreatingAListOfDates()
        {
            List<DateTime> listofDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listofDates.Add(today);
            listofDates.Add(new DateTime(2020 / 12 / 25));
            listofDates.Add(new DateTime(2020, 3, 12));
            listofDates.Add(new DateTime(2020, 11, 14));
                       
        }
        [TestMethod]
        public void MuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get?????");
            int hours = 4; 
            if (hours >= 10)
            {
                Console.WriteLine("wow, that's alot of sleep");
            }

            else if (hours > 8 && hours < 10)

            {
                Console.WriteLine("You should be well rested");
            }

            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }

            else
            {
                Console.WriteLine("oh man get some sleep");
            }
        }
        [TestMethod]
        public void HowHaYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {

                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default: 
                    Console.WriteLine("Please enter something above");
                     break;
            }
        }
        [[TestMethod]
        public void Supercalifragilisticepialocidious()
        {
            string name = "Supercalifragilisticepialocidious";
            foreach(char letter in name)

            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not a i");
                }
            }
        }
    }
}
