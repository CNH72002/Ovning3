using Ovning3.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.WolfAnimal
{
    public class Wolfman : Wolf , IPerson
    {



        public virtual void Talk()
        {
            Console.WriteLine("Wolfman is shouting hahhahhahah...");

        }


        public Wolfman(string name, int age, double weight, double height) : base(name, age, weight, height)
        {

        }




    }
}
