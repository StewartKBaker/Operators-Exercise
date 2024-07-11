namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;

            int sum = a + b;
            Console.WriteLine($"{a} + {b} is {sum}.");
            
            int sub = a - b;
            Console.WriteLine($"{a} - {b} is {sub}.");
            
            int mult = a * b;
            Console.WriteLine($"{a} * {b} is {mult}.");
            

            int quotient = a / b;
            
            
            int remainder = a % b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}.");
            
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}.");
            
        }
    }
}
