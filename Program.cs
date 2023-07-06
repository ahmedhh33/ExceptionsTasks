namespace ExceptionsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Task 1 Dividing ####");
            Console.WriteLine();
            Console.WriteLine("Einter the first number : ");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Einter the second number : ");
            int SecondNumber = int.Parse(Console.ReadLine());
           
            try
            {
                dividing(FirstNumber, SecondNumber);
            } catch (DivideByZeroException ex) 
            { 
                Console.WriteLine("Divide by zero exception");
            }


            Console.WriteLine();
            Console.WriteLine("### Task 2 Checking age ####");
            Console.WriteLine();

            age(12);

            Console.WriteLine();
            Console.WriteLine("### Task 3 Checking file Path ####");
            Console.WriteLine();
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();
            OpeningFile.openFile(filePath);//@"C:\path\to\task3.txt"

            Console.WriteLine();
            Console.WriteLine("### Task 4 Checking file Path ####");
            Console.WriteLine();

            Console.WriteLine("Enter a numerical values to resume and non-numerica value to go out):");

            while (true)
            {
                try
                {
                    string Enteredinput = Console.ReadLine();
                    double doublevalue = Convert.ToDouble(Enteredinput);
                    Console.WriteLine($"You entered: {doublevalue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine(" you Entered Non-numeric input ");
                    
                }
                break;
            }

        }


        public static void dividing(decimal a , decimal b)
        {
            decimal c = a / b;
            //float c = Convert.float(Console.ReadLine());
            Console.WriteLine($" {a}/{b} = {c} ");
        }

        public static void age( int a) 
        {
            Console.WriteLine("Einter Youre Age : ");
            int age = int.Parse(Console.ReadLine());

            try
            {
                if (age <= 0)
                {
                    Console.WriteLine("Invalid Age ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input exception");
            }
        }
    }
}