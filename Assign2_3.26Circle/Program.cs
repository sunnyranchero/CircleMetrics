namespace Assign2_3._26Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a project for IT 1050
            int userRadius;
            const float pi = (float) Math.PI;

            // Get user input as an integer
            Console.WriteLine("Thank you for using our program.");
            Console.WriteLine("This program will take the integer input from the user and compute the diameter, circumference, and area of a circle.\n");
            Console.WriteLine("What is the radius of the circle you would like to compute? \n");
            Console.WriteLine("(Remember to only enter only an integer): ");

            try
            {
                userRadius = int.Parse(Console.ReadLine());


                // Write the lines so the calculation is the variable being output
                Console.WriteLine($"\nFor a circle with a radius of {userRadius}...");
                Console.WriteLine($"The diameter is: {2 * userRadius}");
                Console.WriteLine($"The circumference is: {2 * pi * userRadius}");
                Console.WriteLine($"The area is: {pi * (userRadius * userRadius)}");

                //  Console.WriteLine("The input value was null. Please close the program and try again.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please close the program and try again using only an integer.");
            }
        }
    }
}