using System;

/*
 * Namespace for containing our classes
 */
namespace MonsterCalculator
{
    
    /*
     * Class that contains the needed methods in addition to the main
     * method running on console running. Contains 2 methods for Lab A
     * and Lab B that get user parameters, convert them to correct data type
     * used for math used below that methods calculate.
     */
    class Program
    {

     /*
      * Method for assignment that gets input for number of drinks had
      * Has preset values that will multiply based on input
      */
        public string AssignmentOne()
        {
         
         
            /*
             * preset values used for math
             */
            double cals = 110;
            double sugar = 27;
            double caff = 80;
            
            /*
             * Getting console input variable used in math
             */
            Console.WriteLine("Enter Number Monsters Drank:");
            string monsters = Console.ReadLine();

            /*
            * assigning variables and converting for math below
            */
            double monstersNum = Convert.ToInt32(monsters);


            /*
             * validating input and getting number based on input
             */
            double calories = monsters != "" ? monstersNum * 2 * cals : 0;
            double sugars = monsters != "" ? monstersNum * 2 * sugar : 0;
            double caffeine = monsters != "" ? monstersNum * 2 * caff : 0;
            
            /*
             * writing the output based on math equation
             */
            Console.WriteLine("You consumed:");
            Console.WriteLine(calories + " calories");
            Console.WriteLine(sugars + "g sugar");
            Console.WriteLine(caffeine + "mg caffeine");

            /*
             * return null just run and print
             */
            return null;
        }
    
        
        /*
         * main console method that instantiates a new Program class
         * and runs LabA and LabB methods that will use console.writeline
         * to output the labs required parameters and functions.
         */
        static void Main(string[] args)
        {
            /*
             * create new class and run both methods
             */
            Program A = new Program();
            A.AssignmentOne();
        }
    }
}