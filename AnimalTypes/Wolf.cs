using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.AnimalTypes
{
    public class Wolf :Animal
    {

        private string breed;

        public string Breed
        {
            get { return breed; }

            set
            {
                if (value != string.Empty)
                {
                    breed = value;
                }
                else
                {
                    // throw new ArgumentException(String.Format("does not meet the requirement," +
                    //  " Dog color must not be an empty string"));

                    breed = "Asian"; //Default
                    // Default was choosen  to avoid  the program from throwing exception all the time a user error is made
                }

            }
        }




        public Wolf(string name, int age, double weight, double height): base(name, age, weight, height)
        {
            Breed = breed;

        }


        public override void DoSound()
        {
            Console.WriteLine("The Wolf backs kakakakaka!");

        }

        public override string Stats()
        {
            string result = "";

            result += base.ToString();

            return result += ", Wolf Breed : " + Breed;

        }

    }
}
