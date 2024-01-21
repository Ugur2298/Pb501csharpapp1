namespace week2app2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add day of the week");

            int dayOfTheWeek=int.Parse(Console.ReadLine());
            if (dayOfTheWeek==1)
            {
                Console.WriteLine("Monday: Go to work, study English");
            }
            else if (dayOfTheWeek == 2)
            {
                Console.WriteLine("Tuesday: Go to work, study Coding");
            }
            else if (dayOfTheWeek == 2)
            {
                Console.WriteLine("Tuesday: Go to work, study Coding");
            }
            else if (dayOfTheWeek == 3)
            {
                Console.WriteLine("Wednesday: Go to work, reading Book");
            }
            else if (dayOfTheWeek == 4)
            {
                Console.WriteLine("Thrusday: Go to work, study Coding");
            }
            else if (dayOfTheWeek == 5)
            {
                Console.WriteLine("Friday: Go to work, study English");
            }
            else if (dayOfTheWeek == 6)
            {
                Console.WriteLine("Saturday: Go to work, Go to Code Academy");
            }
            else
            {
                Console.WriteLine("Sunday: Go to work, Go to Code Academy");
            }
        }
    }
}