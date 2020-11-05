﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwL7Task2
{
    class rndmNum
    {
        int value;
        int steps;

        public int Value { get { return this.value; } }
        public int Steps { get { return this.steps; } }

        public rndmNum (int max)
        {
            start(max);
        }

        public void start(int max)
        {
            Random rand = new Random();
            this.value = rand.Next(0, max + 1);
        }

        public string CheckValue(out bool check, int userAnswer)
        {
            if (userAnswer == this.value)
            {
                check = true;
                return $"Поздравлем, вы угадали за {this.steps} ходов!";
            }
            else if (userAnswer > this.value)
            {
                check = false;
                steps++;
                return $"Введённое число большое, попробуйте ещё раз!";
            }
            else
            {
                check = false;
                steps++;
                return $"Введённое число слишком мало, попробуйте ещё раз!";
            }
        }

        public void Reset(int max)
        {
            start(max);
            this.steps = 0;
        }
    }
}


    
