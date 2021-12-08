using Ovning3.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.ExtraAnimal
{
    public class Pelican :Bird
    {

        private string eyeColor;

        public string Eyecolor
        {
            get { return eyeColor; }

            set
            {
                if (value != string.Empty)
                {
                    eyeColor = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("does not meet the requirement," +
                        " Pelican eye color must not be an empty string"));
                }

            }
        }

        public Pelican(string name, int age, double weight, double height): base(name, age,weight,height)
        {
            Eyecolor = eyeColor;
        }







    }
}
