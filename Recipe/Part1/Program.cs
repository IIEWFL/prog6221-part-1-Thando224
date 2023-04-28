using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        public void CreateRecipe() //I created a method CreateRecipe() inside the class which prompts the user for all the recipe information required. This method will be inherited by any instance of this class.
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Welcome to TidoRecipes!");
            Console.WriteLine("*********************************************************************");


            Console.WriteLine();
            // Get the number of ingredients
            Console.Write("Enter the number of ingredients: ");
            recipeVar.numOfIngredients = int.Parse(Console.ReadLine());

            //declare size of array according to numOfIngredients

            recipeVar.ingArray = new string[recipeVar.numOfIngredients];

            //the array value is now known
            Console.WriteLine("size of array=" + recipeVar.ingArray.Length);
            Console.WriteLine();


            //1.b the user inputs the names of the ingredients
            for (int i = 0; i < recipeVar.numOfIngredients; i++)
            {
                Console.WriteLine("Enter the name");
                recipeVar.ingName = Console.ReadLine();
                //save to array
                recipeVar.ingArray[i] = recipeVar.ingName;

                // the user inputs the quantity of that ingredient 
                recipeVar.quantityArray = new double[recipeVar.numOfIngredients];
                Console.WriteLine("Enter quantity");
                recipeVar.ingQuantity = int.Parse(Console.ReadLine());
                recipeVar.quantityArray[i] = recipeVar.ingQuantity;

                //user inputs the unit measurement of the ingredient
                recipeVar.unitArray = new string[recipeVar.numOfIngredients];
                Console.WriteLine("Enter the unit");
                recipeVar.ingUnit = Console.ReadLine();
                recipeVar.unitArray[i] = recipeVar.ingUnit;


                Console.WriteLine("End of ingredient " + (i + 1));
                Console.WriteLine();

            }
            //1.c user inputs the number of steps for the ingredients
            Console.WriteLine("Enter the amount of steps");
            recipeVar.numOfSteps = int.Parse(Console.ReadLine());//this gives us the index value

            recipeVar.stepsArray = new string[recipeVar.numOfSteps];


            //the array value is now known
            Console.WriteLine("size of array = " + recipeVar.stepsArray.Length);
            Console.WriteLine();


            //1.d user inputs the description of each step 
            for (int i = 0; i < recipeVar.numOfSteps; i++)
            {
                recipeVar.descriptArray = new string[recipeVar.numOfSteps];
                Console.WriteLine("Enter a brief description of step " + (i + 1));
                recipeVar.descriptionOfSteps = Console.ReadLine();
                recipeVar.descriptArray[i] = recipeVar.descriptionOfSteps; //store in array
               
            }
        }


            static void Main(string[] args)
            {
            Program create = new Program(); //I made use of the new keyword to create an instance of the class Program.I named this instance create.
            create.CreateRecipe();  //I invoke the method CreateRecipe() using the newly created instance.


            while (true)
            {
                Console.WriteLine("\n\nWhat would you like to do?");
                Console.WriteLine("1. Display the recipe");
                Console.WriteLine("2. Scale the recipe");
                Console.WriteLine("3. Reset the quantities");
                Console.WriteLine("4. Clear all data and enter new recipe details");
                Console.WriteLine("5. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        recipeVar.printFullRecipe();
                        break;

                    case "2":
                        recipeVar.Scalequantities();
                        break;

                    case "3":
                        recipeVar.ResetQuantities();
                        break;

                    case "4":
                         recipeVar.ClearRecipe();
                        Program create1 = new Program(); //I made use of the new keyword to create an instance of the class Program.I named this instance create1.
                        create1.CreateRecipe();  //I invoke the method CreateRecipe() using the newly created instance.
                        break;
                   
                    case "5":
                        recipeVar.ExistApp();
                        break;
                }


            }
        }
    }
}
