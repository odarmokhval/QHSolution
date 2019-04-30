using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH4
{
    class Cat
    {
        readonly string name;

        private double _energy;

        private double GetEnergy() {
            return _energy;
        }

        public static readonly double MaxEnergy = 20;

        public static readonly double MinEnergy = 0;

        public static readonly double SleepEnergyGain = 10;

        public static readonly double JumpEnergyDrain = 0.5;

        public static double Energy { get; private set; }             


        public Cat(string name){

            this.name = name;

        }

        public static void Jump()
        {
            Energy = Energy - JumpEnergyDrain;
        }


        public static void Sleep()
        {
            Energy = Energy + SleepEnergyGain;
        }          
    }
}
