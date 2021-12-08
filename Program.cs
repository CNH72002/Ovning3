using Ovning3.AnimalTypes;
using Ovning3.CustomClasses;
using Ovning3.WolfAnimal;
using System;
using System.Collections.Generic;
//Done by Ngozi Henry Chukwueweniwe 2021-12-08

namespace Ovning3
{
    class Program
    {

        //Test the person class
        public static void CreatePerson()
        {
            
             try
              {
                Console.WriteLine("Person object created is : \n");

                 Person person = new Person("John", "Erik", 24, 70.5, 67.8);
                Console.WriteLine(person.ToString());

                Console.WriteLine();

                Console.WriteLine("Press any key to test PersonHandler class....\n");

                //Answer: Fields cannot be access easily. It can ONLY be accessed 
                //through the properties of the instance object (person).

            }
             catch(Exception e)
             {
                 Console.WriteLine("Fail to create person object. Reason :" + e.Message);

             }

        }


        //Test PersonHandler class
        public static void TestPersonHandler()
        {
            try
            {

                  PersonHandler obj = new PersonHandler(); //Create an object of PersonHandler
                  //Fill it with data
                  Person person = obj.CreatePerson(15, "Erik", "Johansson", 180.25, 67.5);
                  Person person2 = obj.CreatePerson(15, "Mary", "Blesinge", 170.25, 87.5);
                  Person person3 = obj.CreatePerson(45, "Desi", "Felix", 140.25, 77.5);

                //Print it on the console
                Console.WriteLine("List of person objects created are :");
                Console.WriteLine();

                  Console.WriteLine(person.ToString());
                  Console.WriteLine(person2.ToString());
                  Console.WriteLine(person3.ToString());

                  //Add the objects to the collection
                  obj.AddPerson(person);
                  obj.AddPerson(person2);
                  obj.AddPerson(person3);

               Console.WriteLine();
               

                Console.WriteLine();

                //Rrint the number of objects added to the collection
                Console.Write("Number of objects in the list :  ");
                Console.WriteLine(obj.Count);

                Console.WriteLine();
                Console.WriteLine("List of objects added to the list\n");
                //Copy all the elements in the collection to an array
                string[] myArray = obj.ListToStringArray();
               
                //Print all items in the array
                foreach (var ep in myArray)
                  {
                      Console.WriteLine(ep);
                  }

                Console.WriteLine();
                Console.WriteLine("Press any key to Test animal sounds....\n");

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Failure to create a Person object because :  " + e.Message);
            }



        }


        //Declared objects.
        static Dog dog;
        static Bird bird;
        static Hegehog hegehog;
        static Horse horse;
        static Wolf worlf;
        static Worm worm;

        public static void TestAnimalSound()
        {
            Console.WriteLine();
            //Create a dog and make sound
            dog = new Dog("dogg", 10, 24.7, 20);
            dog.DoSound();

           
            Console.WriteLine("Press any key to continue....\n");
            Console.ReadKey();

            //Create a bird and make sound
            bird = new Bird("soko", 13, 14.7, 4);
            bird.DoSound();

          
            Console.WriteLine("Press any key to continue....\n");
            Console.ReadKey();

            //Create a hegehog and make sound
            hegehog = new Hegehog("sisi", 12, 4.67, 3);
            hegehog.DoSound();

           
            Console.WriteLine("Press any key to continue....\n");
            Console.ReadKey();

            //Create a horse and make sound
            horse = new Horse("deti", 9, 200.7, 60.6);
            horse.DoSound();

           
            Console.WriteLine("Press any key to continue....\n");
            Console.ReadKey();

            //Create a wolf and make sound
            worlf = new Wolf("koko", 5, 10.24, 6);
            worlf.DoSound();

           
            Console.WriteLine("Press any key to continue....\n");
            Console.ReadKey();

            //Create a worm and make sound
            worm = new Worm("sasa", 2, 1.5, 1);
            worm.DoSound();

           
            Console.WriteLine("Press any key to test the Wolfman Class....\n");
            Console.ReadKey();

        }

        public static void TestWolfman()
        {
            Console.WriteLine();
            Wolfman wolfman = new Wolfman("wolfname", 12, 23.5, 22.7);

            wolfman.Talk();

            Console.WriteLine("Press any key to the animals created\n");
            Console.WriteLine();
        }


        //Fråga 13.  Vi ska lägga det i klassen Bird
        //Fråga 14. Vi ska lägga det in klassen Animal


        private static List<Animal> animalList;

        public static void CreateAnimals()
        {
            animalList = new List<Animal>();  //Create a list
           

            //Create animal objects
            Animal dog = new Dog("Titi", 8, 10.3, 6.6);
            Animal bird = new Bird("sisi", 3, 4.6, 3.7);
            Animal hegehog = new Hegehog("didi", 2, 4.8, 6.6);
            Animal wolf = new Wolf("koko", 7, 10.45, 6.7);
            Animal horse = new Horse("Roy", 5, 200.56, 60.4);
            Animal worm = new Worm("nass", 4, 5.5, 3.1);

            //Add all the created objects to the list.
            animalList.Add(dog);
            animalList.Add(bird);
            animalList.Add(hegehog);
            animalList.Add(wolf);
            animalList.Add(horse);
            animalList.Add(worm);
           

            Console.WriteLine("Press any key to continue....\n");

            //Show the number of objects in the list
            Console.Write("Number of animal objects in the list is : " + animalList.Count);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue ....\n");
            Console.ReadKey();

            Console.WriteLine("List of animal objects created in the list \n");
            

            //List all the animal objects in the list
            foreach (Animal obj in animalList)
            {
                Console.WriteLine(obj );
                
            }

            Console.WriteLine("Press any key to continue....\n");
            Console.ReadKey();

            //Print all the sound made by all animals on the console.

            Console.WriteLine("List of all sounds made by the created animals\n");
            foreach (Animal obj in animalList)
            {
                obj.DoSound();
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to test the typecasting of animal objects");
            Console.WriteLine("and test the casted object Talk() method"); 
            Console.ReadKey();
            Console.WriteLine();

            //Tycast all animal object to Person object


            for(int i =0; i <animalList.Count; i++)
            {
                Person myPer = TestTypeCast(animalList[i]);
                myPer.Talk();  // Now all typcasted animal objects to person object can talk.
            }

            Console.WriteLine();
            Console.ReadKey();


        }


        //Method to typecast an animal object to Person object
        static Person TestTypeCast(Animal a)
        {
            Person r = (Person)a;
            return r;

        }


       
        public static void DogList()
        {
            List<Dog> myDogList = new List<Dog>();
            Horse myhorse = new Horse("myRide", 12, 200.56, 40.7);


            //Fråga 3.3 - (8)
            // myDogList.Add(myhorse);
            //Det fungerar inte. Det går inte att lägga myhorse objekt till myDogList.
            //Eftersom myhorse är inte samma typ som Dog. myDogList kan tillåter bara Dog typ.
            //För att kunna spara alla animal typ, måste lista vara List<Animal>

        }


        public static void PrintAllAnimalStats()
        {
            Console.WriteLine("List of all the animal statistics in the list\n");
            Console.WriteLine("YOU NEED TO ADD EXTRA DATA NEEDED TO COMPLETE EACH OBJECT !!!!");

           foreach(Animal ani in animalList)
            {
                if(ani is Bird)  //Check if this is Bird object
                {
                    Console.WriteLine();
                    Bird b = (Bird)ani;  //Cast this object to Bird object
                    b.FlyingSpeed = Utilities.ReadDouble();  //Set value
                    Console.WriteLine(ani.Stats()); //Print complete bird stat
                }
                if (ani is Dog)  //Check if this is Dog object
                {
                    Console.WriteLine();
                    Dog d = (Dog)ani; //Cast this object to Dog object
                    d.Color = Utilities.ReadString();   //Set value
                    Console.WriteLine(ani.Stats()); //Print complete dog stat
                }
                if (ani is Hegehog)  //Check if this is Hegohog object
                {
                    Console.WriteLine();
                    Hegehog h = (Hegehog)ani;  //Cast this object to hegehog object
                    h.Noofspike = Utilities.ReadInteger();    //Set value
                    Console.WriteLine(ani.Stats()); //Print complete hagehog stat
                }
                if (ani is Wolf)  //Check if this is Wolf object
                {
                    Console.WriteLine();
                    Wolf w = (Wolf)ani;   //Cast this object to Wolf object
                    w.Breed = Utilities.ReadString2();    //Set value
                    Console.WriteLine(ani.Stats());  //Print complete wolf stat
                }
                if (ani is Worm)  //Check if this is worm object
                {
                    Console.WriteLine();
                    Worm wo = (Worm)ani;  //Cast this object to worm object
                    wo.HeadColor = Utilities.ReadString3();  //Set value
                    Console.WriteLine(ani.Stats());  //Print complete worm stat
                }
                if (ani is Horse)  //Check if this is Horse object
                {
                    Console.WriteLine();
                    Horse ho = (Horse)ani;  //Cast this object to Horse object
                    ho.TailLenght = Utilities.ReadDouble2();   //Set value
                    Console.WriteLine(ani.Stats()); //Print complete horse stat
                }


            }



            Console.WriteLine("Press any key to print the dog only statistics");

        }


        //This method prints only dog statistics in the list
        public static void PrintStatForDogOnly()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Statistic of only Dog objects in the List\n");
            foreach (Animal ani in animalList)
            {

                if (ani is Dog)  //Check if this is Dog object
                {
                    Dog d = (Dog)ani; //Cast this object to Dog object
                    
                    Console.WriteLine(d.Stats()); //Print complete dog stat
                }

            }

            Console.WriteLine("Press any key to continue...");
            
        }




        //Fråga 3.3 (17)
        //Man kan inte komma åt det eftersom Denna metod kan inte nås från 
        //"Animal" listan eftersom "Animal" klassen 
        // inte ärver "Dog" klassen. Men det är tvärtom. Denna metod är specifik för hundklassen




        //This method prints the method MyString() in the Dog class using foreach loop on the animal list
        public static void PrintDogString()
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is the dog string");

            foreach(Animal x in animalList)
            {

                if (x is Dog)  //Check if this is Dog object
                {
                    Dog d = (Dog)x; //Cast this object to Dog object
                   
                    Console.WriteLine(d.MyString() ); //Print complete dog string
                }

            }

           

            Console.WriteLine("Press any key to test the UserError class----\n");
            Console.WriteLine();
            Console.ReadKey();
        }



         static List<UserError> errorList = new List<UserError>();

        //This method displays all the message in the user error list
        public static void FillErrorList()
        {
            Console.WriteLine();
            NumericInputError nInput = new NumericInputError();
            TextInputError tInput = new TextInputError();

            errorList.Add(nInput);
            errorList.Add(tInput);

            foreach(UserError ep in errorList)
            {
                Console.WriteLine();
                Console.WriteLine( ep.UEMessage() );
            }

            Console.WriteLine("Press any key to test the Custom classes....");
            Console.ReadKey();
        }


        //Testing three new classes created.
        public static void TestCustomClasses()
        {
            FirstClass firstclass = new FirstClass();
            errorList.Add(firstclass);

            SecondClass secondclass = new SecondClass();
            errorList.Add(secondclass);

            ThirdClass thirdclass = new ThirdClass();

            errorList.Add(thirdclass);

            Console.WriteLine("This is the error messages in the error list\n");
            Console.WriteLine();

            foreach(UserError us in errorList)
            {
                Console.WriteLine(us.UEMessage());

            }

            Console.WriteLine("Press any key to terminate the program\n");
        }





        static void Main(string[] args)
        {

             CreatePerson();   //No. 1  //Create a Person object

            Console.ReadKey();

            TestPersonHandler(); //No. 2  // Test PersonHandler class

            Console.ReadKey();

            TestAnimalSound();  //No. 3   //Test Animals sound


            TestWolfman(); // No. 4    // Test the wolfMan class

            Console.WriteLine();

            CreateAnimals();   //No. 5    // Create animals

            Console.WriteLine();

            PrintAllAnimalStats();  //No. 6   //Print all anomal statistics in the list

            PrintStatForDogOnly(); // No. 7     //Print only dog statistics in the list

            Console.ReadKey();

            PrintDogString();   //No. 8     // Print dog string in the method

            FillErrorList();  //No. 9    // Fill error list and print all errors in the list

            TestCustomClasses(); // No. 10    //Test my custom classes.


        }



       



    }
}
