using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public abstract class Animal :Person  //Animal is also a person
    {
        private string name;
        private int age;
        private double weight;
        private double height;


        public string Name
        {
            get { return name; }

            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} does not meet the requirement," +
                        "  the lenght must be between 2 and 10 inclusive", value));
                }

            }
        }

        public int Age1
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;

                }
                else
                {
                    throw new ArgumentException(String.Format("{0} does not meet the requirement," +
                        " The value must not be less than zero", value));
                }
            }
        }


        //Property for weight
        public double Weight1
        {
            get { return weight; }
            set
            {
                if (value >= 0)
                {
                    weight = value;

                }
                else
                {
                    throw new ArgumentException(String.Format("{0} does not meet the requirement," +
                        " The value must not be less than zero", value));

                }
            }
        }


        //Property for height
        public double Height1
        {
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    height = value;

                }
                else
                {
                    throw new ArgumentException(String.Format("{0} does not meet the requirement," +
                        " The value must not be less than zero", value));

                }

            }
        }


        //Contructor with parameters
        public Animal(string name, int age, double weight, double height)
        {
            Name = name;
            Age1 = age;
            Weight1 = weight;
            Height1 = height;

        }




        public override string ToString()
        {
            return $"Object detail is: \n Name : {Name}, Age : {Age1}, Weight : {Weight1}, Height : {Height1} ";
        }


        //Abstract method

        public abstract void DoSound();


        public abstract string Stats();
        

        



    }
}
