﻿using System;

namespace AgileCoffeeShop
{
    public class Coordinate
    {
        private double _xCoordinate;
        private double _yCoordinate;
        const int MAX = 180;
        const int MIN = 90;
        public double XCoordinate
        {
            get
            {
                return _xCoordinate;
            } 
            set
            {
                if(value >=-MAX && value <= MAX)
                {
                    _xCoordinate = value;
                }
                else
                {
                    Console.WriteLine("Invalid value for x coordinate. Program will exit.\nPress any key to continue...");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
            }
        }

        public double YCoordinate
        {
            get
            {
                return _yCoordinate;
            }
            set
            {
                if (value >= -MIN && value <= MIN)
                {
                    _yCoordinate = value;
                }
                else
                {
                    Console.WriteLine("Invalid value for y coordinate. Program will exit.\n Press any key to continue...");
                    Console.ReadKey();
                    Environment.Exit(-1);
                } 
            }
        }    

        public Coordinate ()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }
    }
}
