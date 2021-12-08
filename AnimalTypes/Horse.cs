using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.AnimalTypes
{
    public class Horse :Animal
    {
        //Fields
        private double tailLenght;

        
        //Property
        public double TailLenght
        {
            get { return tailLenght; }
            set
            {
                if (value > 0)
                    tailLenght = value;
            }

        }


       
        //Constructor

        public Horse(string name, int age, double weight, double height) : base(name,age,weight, height)
        {
            TailLenght = tailLenght;
        }

        //Sound method
        public override void DoSound()
        {
            Console.WriteLine("The horse makes rrrrrrrrrrrr!");

        }


        //This method displays all the stat of the horse object
        public override string Stats()
        {
            string result = "";

            result += base.ToString();

            return result += ", Tail lenght : " + TailLenght;


        }

    }
}
