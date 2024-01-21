namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float firstNumber;
            float secondNumber;

            Console.WriteLine("Please enter first number");
            firstNumber=float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            secondNumber = float.Parse(Console.ReadLine());

            float resultSum= firstNumber+secondNumber;
            Console.WriteLine("Addition result: "+ resultSum);

            float resultMinus= firstNumber-secondNumber;
            Console.WriteLine("Minus result: "+ resultMinus);

            float resultMuliply= firstNumber*secondNumber;
            Console.WriteLine("Multiply result: "+ resultMuliply);

            float resultDivision= firstNumber/secondNumber;
            Console.WriteLine("Division result: "+ resultDivision);

            Console.WriteLine("Hello World");




        }
    }
}