using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class PersonHandler
    {
        private List<Person> personList;


       
        public PersonHandler()
        {
            personList = new List<Person>();

        }



        public List<Person> PersonList
        {
            get { return personList; }
            set { personList = value; }
        }



        public int Count  // Property
        {
            get { return personList.Count; }    //Get the number of elements(count) in the list
        }


        //Check index method for validity of an index given by the user
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < personList.Count);

        }


        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        public void SetAge(Person pers, int age)
        {
            pers.Age =  age;

        }



        //This method create a person object 
        public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {
            Person person = new Person(fname, lname, age, height, weight);
             if (person != null)
            {
                return person;

            }
            else
            {
                return null;
            }
            
               
           
        }

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        #region

        //This method adds a person object to the list 
        public bool AddPerson(Person per)
        {
            bool ok = false;
            if(per != null)
            {
                personList.Add(per);
                //personList.Sort((x, y) => x.Age.CompareTo(y.Age));  //Sort by age. 
                ok = true;
            }

            return ok;

        }


        //The method removes a person object from the list.
        public bool RemovePerson(int index)
        {
            bool ok = false;
            if (CheckIndex(index))   // Validate index
            {
                personList.RemoveAt(index);   // remove object at index
                ok = true;        // set the variable to true if delete was sucessfull
            }

            return ok;    // Return the value of ok.


        }

        //This method removes a person object from an index value and replace 
        // another person object at the same index position

        public bool ChangePerson(Person per, int index)
        {
            bool ok = false;
            if ((per != null) && CheckIndex(index))  // Validation performed here
            {
                personList[index] = per;    //Insert the person object at this index in the list.
                ok = true;
            }
            return ok;


        }


        //This method converts the personList elements to Array with a fixed size given by the count in the list.

        public string[] ListToStringArray()
        {
            string[] personArray = new string[Count];  // Create and declare and array

            for (int i = 0; i < Count; i++)
                personArray[i] = personList[i].ToString();   //copy all the elements in the list  to the array.

            return personArray;

        }


        #endregion


    }
}
