using Ovning3.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.ExtraAnimal
{
    public class Flamingo:Bird
    {
        private double legLenght;

        public double LegLenght
        {
            get { return legLenght; }

            set
            {
                if (value > 0.0)
                {
                    legLenght = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("does not meet the requirement," +
                        " value must not be less than zero"));
                }

            }
        }



        public Flamingo(string name, int age, double weight, double height) : base(name, age, weight, height)
        {
            LegLenght = legLenght;
        }


    } 
}
