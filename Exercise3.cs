namespace Exercise_3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a Part to run [A|B|C]\n");
            string? rawPart = Console.ReadLine();

            if (rawPart == null || rawPart.Length < 1)
            {
                throw new ArgumentException("Part not provided!");
            }

            string part = rawPart.ToUpper();
            string[] allowedParts = { "A", "B", "C" };

            if (!allowedParts.Contains(part))
            {
                throw new ArgumentException("Part provided is not valid!");
            }

            switch (part) 
            {
                case "A": 
                    PartA();
                    break;
                
                case "B": 
                    PartB();
                    break;
                
                case "C": 
                    PartC();
                    break;

                default: throw new ArgumentException("Unknown exception");
            }
        }

        static void PartA()
        {
            Console.WriteLine("This program will ask For Your Age And Current GPA and Prints them on the screen.\n");
            Thread.Sleep(1000);

            Console.Write("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);

            Console.Write("\nPlease enter Your GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("\nAge That Was Entered " + age);
            Console.WriteLine("\nGPA Entered Was: " + gpa);
            Thread.Sleep(1000);

            Console.WriteLine("GoodBye!");
            Thread.Sleep(2000);
            Console.Clear();

            

        }

        static void PartB()
        {

            double baseLength, height, area;

            Console.WriteLine("This program calculates the area of a triangle.");
            Console.Write("Enter the length of the base: ");
            baseLength = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            height = double.Parse(Console.ReadLine());

            area = 0.5 * baseLength * height;

            Console.WriteLine("The area of the triangle is: " + area);

        }
        static void PartC()
        {
            Console.WriteLine("This program asks for a number and multiplies it by 5\n");

            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int product = num * 5;

            Console.WriteLine("\nProduct = " + product);
        }
    }
}




