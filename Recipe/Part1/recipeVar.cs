using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part1
{
    internal class recipeVar
    {
        //arrays are declared here
        public static string[] ingArray; // this will store the names of all the ingredients entered by the user
        public static string[] stepsArray; // this stores the number of steps entered by the user
        public static double[] quantityArray; // this stores the quantity of the ingrdient name entered by user
        public static string[] unitArray;// this will store the unit of measurement for the ingredient name
        public static string[] descriptArray; // this stores the description of each step that depent on the number of steps the user entered

        //storing all varibales used in porogrm
        public static int numOfIngredients = 0; // this variabl stores the number of ingredients the user enters
        public static string ingName = ""; // this variable stores the name of each ingredient
        public static int numOfSteps = 0; //this variable stores the number of steps required for the recipe 
       public static double ingQuantity = 0.0; // its called ingQuantity because it refers to the ingredient quantity entered by the user
        public static string ingUnit = ""; // its called ingUnit because it refers to the ingrdient unit of measurement and stores the unit entered
        public static string descriptionOfSteps = ""; // this stores the description of each step needed. 
        
        
        //Methods

        public static void printFullRecipe()  //this method displays the all the input the user entered of which was stored in memory using arrays. i also made use of a for loop to store and read the array index
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();  
            Console.WriteLine("Here are your full recipe details:");
            Console.WriteLine("Number of Ingredients : " +numOfIngredients);
            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.WriteLine("Each Ingredient consists of the Name: " + ingArray[i] + " " + "the Quntity: " + quantityArray[i] + " " + "Unit of Measurement is :" + unitArray[i]);
            }

            Console.WriteLine("Number of steps: " + numOfSteps);
            for (int i = 0; i < numOfSteps; i++)
               
            {
                Console.WriteLine("Description of each step: " + descriptArray[i]);
            }
         Console.ResetColor();
        }

        
        public static void Scalequantities() // this method will ask to the user if they wish to scale up, should they agree it will store their input in the variable name scalename of which will be used to compare in the if statement
        {
        Console.WriteLine("Do you want to scale up your ingredients? Enter (1) Yes or Enter (2) No;");
        int Scaleanswer = int.Parse(Console.ReadLine());

            if (Scaleanswer == 1)
            {
                Console.WriteLine("Enter one of the scales between 0.5, 2 and 3");
                double factor = Convert.ToDouble(Console.ReadLine());   
                factor *= quantityArray[0]; //the *= operator multiples the value of the array index stored by the value of the variable on the left
                Console.WriteLine(factor);
                
            }
        }

        public static void ResetQuantities() //this method sets all the valu
        {
         Console.WriteLine("Do you want reset the quanties? Enter (1) Yes or Enter (2) No;");
         int Resetanswer = int.Parse(Console.ReadLine());

            if (Resetanswer == 1) 
            { 
            ingQuantity = 0.0;  
            }
        }

        public static void ClearRecipe() //this method clears out all the input entered from the beginning of the program and clears out anything stored in the arrays so that a new recipe can be entered
        { 

            for(int i = 0; i < ingArray.Length; i++)
            {
               ingArray[i] = null;
                unitArray[i] = null;
                quantityArray[i] = 0;
            }

          for (int i = 0; i < stepsArray.Length; i++)
          {
               stepsArray[i] = null;
               descriptArray[i] = null;        
           }

           
        }

        public static void ExistApp() // this method terminates the application immediately
        { 
        Environment.Exit(0);    
        }
    }

}
