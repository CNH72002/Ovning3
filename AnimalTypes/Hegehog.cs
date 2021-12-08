using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Done by Ngozi Henry Chukwueweniwe 2021-12-08

namespace Ovning3.AnimalTypes
{
    public class Hegehog :Animal
    {
        private int noOfSpikes; //Field

        //Property
        public int Noofspike
        {
            get { return noOfSpikes; }
            set
            {
                if (value > 0)
                {
                    noOfSpikes = value;

                }
                
                    
            }

        }

       

        public Hegehog(string name, int age, double weight, double height): base(name, age, weight, height)
        {
            Noofspike = noOfSpikes;

        }

        public override void DoSound()
        {
            Console.WriteLine("The Hegohog backs like zzzzzzz!");

        }

        public override string Stats()
        {
            string result = "";

            result += base.ToString();

            return result += ", Number of spikes : " + Noofspike;

        }

    }
}
