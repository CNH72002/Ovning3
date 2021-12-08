using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.AnimalTypes
{
    public class Worm :Animal 
    {

        private string headColor;

        public string HeadColor
        {
            get { return headColor; }
            set { headColor = value; }
        }


       /* public Worm(string headColor)
        {
            HeadColor = headColor;

        }*/

        public Worm(string name, int age, double weight, double height) : base(name, age, weight, height)
        {
            HeadColor = headColor;

        }

        public override void DoSound()
        {
            Console.WriteLine("The worm sounds  nnnnnn!");

        }


        public override string Stats()
        {
            string result = "";

            result += base.ToString();

            return result += ", Head Color : " + HeadColor;

        }



    }




}
