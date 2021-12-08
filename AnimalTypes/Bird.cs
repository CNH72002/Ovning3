using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.AnimalTypes
{
    public class Bird :Animal
    {

        private double flyingSpeed;   // flying speed

        public double FlyingSpeed
        {
            get { return flyingSpeed; }
            set
            {
                if (value > 0)
                {
                    flyingSpeed = value;
                }
                
                    
            }
            
            
            

        }


      


        public Bird(string name, int age, double weight, double height) : base(name, age, weight, height)
        {
            FlyingSpeed = flyingSpeed;
        }


        public override void DoSound()
        {
            Console.WriteLine("The bird makes sound  shshshshss!");

        }

        public override string Stats()
        {
            string result = "";

            result += base.ToString();

            return result += ", Flying Speed : " + FlyingSpeed;

        }

    }
}
