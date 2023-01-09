using System;

namespace PbjSandwichMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program loop
            bool keepLooping = true;
            while (keepLooping)
            {
                //Request number of people that require sandwiches
                Console.WriteLine("Welcome to the PBJ Sandwich maker!\n");
                Console.Write("How many people are we making PB&J sandwiches for?: ");

                //Parse number and store in a variable
                int number = int.Parse(Console.ReadLine());

                //Requirements for a sandwich
                int slices = 2;
                int PBtablespoons = 2;
                int jellyteaspoons = 4;

                //Unit sizes. 28 slices/loaf; 32 tablespoons/PBJ jar; 48 teaspoons/jelly jar
                int slicesPerLoaf = 28;
                int PBJar = 32;
                int jellyJar = 48;

                //Calculations
                int totalSlicesNeeded = number * slices;
                int totalPBNeeded = number * PBtablespoons;
                int totaljellyNeeded = number * jellyteaspoons;
                int totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf;
                int totalPBJarsNeeded = totalPBNeeded / PBJar;
                int totaljellyJarsNeeded = totaljellyNeeded / jellyJar;

                //Round up numbers
                if (totalSlicesNeeded % slicesPerLoaf != 0) totalLoavesNeeded++;
                if (totalPBNeeded % PBJar != 0) totalPBJarsNeeded++;
                if (totaljellyNeeded % jellyJar != 0) totaljellyJarsNeeded++;

                //Display results
                Console.WriteLine($"You need\n\n 1. {totalSlicesNeeded} slices of bread\n 2. {totalPBNeeded} tablespoonsfull of peanut butter\n 3. {totaljellyNeeded} teaspoonsfull of jelly\n\n which is\n\n 1. {totalLoavesNeeded} loaf/loaves of bread\n 2. {totalPBJarsNeeded} jar(s) of peanut butter\n 3. {totaljellyJarsNeeded} jar(s) of jelly");

                //Ask to continue
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Console.Write("Enter yes or y to start over, or any other key to exit: ");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "yes": continue; //restart the loop
                    case "y": continue; //restart the loop
                    default:
                        Console.WriteLine(" Goodbye!");
                        keepLooping = false; //stop the loop from running 
                        break;
                }
            }
        }
    }
}

//Build Specifications
//Each sandwich requires 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly
//Assume 1 sandwich per person
//Assume 1 loaf of bread contains exactly 28 slices
//Assume 1 jar of peanut butter contains exactly 32 tablespoons
//Assume 1 jar of jelly contains exactly 48 teaspoons
//First, ask the user, “How many people are we making PB&J sandwiches for?” Expect the user to enter a number. You’ll need to parse the input and store it in a number variable.
//You can now calculate the total amount of slices, tablespoons, and teaspoons needed. Print out these values to the console (see the console example below). 

//Next, calculate how many loaves are needed. The formula is totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf. But since we can't buy partial loaves, round up the answer. For example, if 1.3 loaves are needed, we need to round that up and get 2 loaves. (Hint: search online how to round numbers up in C#.)
//Do the same calculation for jars of peanut butter and jars of jelly. These also require rounding up.
//Print out all three of these totals. (again, see the console example below)
//After printing out all of the results, ask the user if they would like to start the program over. If yes, loop through the program again. If the user answers anything other than ‘y’ or “yes”, print "Goodbye" and exit the program.


