using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        //Import RandArray class
        RandArray ar;
        ar = new RandArray();
        
        //Gather user input
        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many rolls would you like to simulate?");
        int numRolls = int.Parse(Console.ReadLine());

        //Pass data to a new class "RandArray"
        //Assign the returned array to 'result'
        int[] result = ar.createArray(numRolls);

        //Write the results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
            "Each '*' represents 1% of the total number of rolls.\n" +
            "Total number of rolls = " +  numRolls + ".\n");

        for (int i = 2; i < result.Length; i++) //for every spot in the array
        {
            //calulate the percentage
            int pct = result[i] * 100 / numRolls;

            //Write the number we are looking at
            Console.Write(i + ": ");
            
            //Write an asterisk for the percent value
            for (int j = 0; j < pct; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

        //thank the user
        Console.WriteLine("\nThank you for using the dice throwing simulator.  Goodbye!");

    }
}