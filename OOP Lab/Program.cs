﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to accept user input
            int station;

            //Declare and instatiate a television object
            Television bigScreen = new Television("Toshiba", 55);

            //Turn the power on
            bigScreen.Power();

            //Display the state of the television
            Console.WriteLine(bigScreen.ToString());

            //Prompt the user for input and store it in the station variable
            Console.WriteLine("What channel do you want? ");
            station = int.Parse(Console.ReadLine());

            //Change the channel on the television
            bigScreen.SetChannel(station);

            //Increase the volumne of the television
            bigScreen.IncreaseVolume();

            //Display the current channel and volumne
            Console.WriteLine("Channel: " + bigScreen.GetChannel() + " Volume: " + bigScreen.GetVolume());

            Console.WriteLine("Too loud!  Lowering the volume.");

            //Decrease the volume
            for (int x = 0; x < 6; x++)
            {
                bigScreen.DecreaseVolume();
            }

            //Display the current channel and volumne
            Console.WriteLine("Channel: " + bigScreen.GetChannel() + " Volume: " + bigScreen.GetVolume());

            //create blank line
            Console.WriteLine();

            //HERE IS WHERE YOU DO TASK 5

            Console.ReadKey();
        }
    }
}
