using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Done by Ngozi Henry Chukwueweniwe 2021-12-08

namespace Ovning3.AnimalTypes
{
    public class Dog :Animal
    {
        //Fields
        private string color;


        //Property
        public string Color
        {
            get { return color; }

            set
            {
                if (value != string.Empty)
                {
                    color = value;
                }
                else
                {
                    //throw new ArgumentException(String.Format("does not meet the requirement," +
                    //   " Dog color must not be an empty string"));

                    color = " white";  //default

                    //Default was choosen  to avoid the program throwing exception all the time a user error is made 

                }

            }
        }




       
        public Dog(string name, int age, double weight, double height) : base(name, age, weight, height)
        {
            Color = color;  //initial value


        }

        //The dog sound method
        public override void DoSound()
        {
            Console.WriteLine("The dog backs ohhhhhhh!");
           
        }


        //This method returns the dog statistics
        public override string Stats()
        {
            string result = "";

            result += base.ToString();

            return result += ", Dog Color : " + Color;


        }


        //The dog string method
        public  string MyString()
        {
            Console.WriteLine();
            Console.WriteLine("This is my string from the dog class\n");


            return "*********This is my string from the dog class*********\n";

        }





    }
}
