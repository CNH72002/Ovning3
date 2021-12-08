using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class Person :IPerson
    {
        #region

        //Fields
        private string fName;
        private string lName;
        private int age;
        private double weight;
        private double height;

        //Properties 

        //Property for first name
        public string Fname 
        { 
            get { return fName; }

            set 
            { 
                if(value.Length >= 2 && value.Length <= 10  )
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} does not meet the requirement," +
                        "  the lenght must be between 2 and 10 inclusive", value) );
                }

            }
        }

        //Property for Last name
        public string Lname
        {
            get { return lName; }


            set 
            {
                if (value.Length >= 3 && value.Length <= 15 )
                {
                    lName = value;

                }
                else
                {
                    throw new ArgumentException(String.Format("{0} does not meet the requirement, " +
                        " the lenght  must be between 3 and 15 inclusive", value) );
                }
            }
        }

        //Property for age
        public int Age
        {
            get { return age; }
            set 
            { 
                if( value >= 0)
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
        public double Weight
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
        public double Height
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


        #endregion


        public Person()
        {

        }

        public Person(string fName, string lName, int age, double height, double weight)
        {
            Fname = fName;
            Lname = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }





        public override string ToString()
        {
            return $"FirstName : {Fname}  LastName : {Lname},  Age : {Age}, Weight = {Weight}";
        }



        public  void Talk()
        {
            Console.WriteLine("The person is talking ......");

        }


    }
}
