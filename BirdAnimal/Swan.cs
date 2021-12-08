using Ovning3.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.ExtraAnimal
{
    public class Swan :Bird 
    {

        private double wingLenght;

        public double WingLenght
        {
            get { return wingLenght; }

            set
            {
                if (value > 0.0)
                {
                    wingLenght = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("does not meet the requirement," +
                        " value must not be less than zero"));
                }

            }
        }



        public Swan(string name, int age, double weight, double height) : base(name, age, weight, height)
        {
            WingLenght = wingLenght;
        }


    }
}
