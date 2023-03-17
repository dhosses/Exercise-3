namespace Exercise_3
{
    internal class PartA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program Will ask For Your Age And Current GPA and Prints them the the screen.\n");
            Thread.Sleep(1000);

            Console.WriteLine("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("\n Please enter Your GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("\nAge That Was Entered " +  age);
            Console.WriteLine("GPA Entered Was: " +  gpa);
            Thread.Sleep(1000);

            Console.WriteLine("\nGoodBye!");
        }
    }
}

