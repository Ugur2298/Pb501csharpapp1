namespace week3day4_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int studentCount = 3;
            //string[] studentsName = new string[studentCount];
            //float[] studentsGrade = new float[studentCount] ;

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("Please enter students name:");
            //    string name=Console.ReadLine();
            //    studentsName[i] = name;
            //    Console.WriteLine("Please enter students grade:");
            //    int grade=int.Parse(Console.ReadLine());
            //    studentsGrade[i] = grade;
            //}
            //Console.WriteLine("Students name and grades are following in the below:");
            //Console.WriteLine("**************");

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"Students grade: {studentsGrade[i]} and Students name: {studentsName[i]}");
            //}

            //int citiesCount = 3;
            //string[] citiesName = new string[citiesCount];
            //float[] citiesPopulation= new float[citiesCount];   



            //for (int i = 0; i < citiesCount; i++)
            //{
            //    Console.WriteLine("Enter city name");
            //    string name=Console.ReadLine();
            //    citiesName[i] = name;
            //    Console.WriteLine("Enter population count:");
            //    float count = int.Parse(Console.ReadLine());
            //    citiesPopulation[i] = count;   
            //}
            //Console.WriteLine("Cities name and population counts are in the following below:");
            //Console.WriteLine("**********************");

            //for (int i = 0; i < citiesCount; i++)
            //{
            //    Console.WriteLine($"Cities name: {citiesName[i]} -------- Citie population count: {citiesPopulation[i]}");
            //}

            //int attempts = 0;
            //while (attempts<citiesCount)
            //{
            //    Console.WriteLine($"Cities name: {citiesName[attempts]} -------- Citie population count: {citiesPopulation[attempts]}");
            //    attempts++;
            //}

            //int[,] arr2d = new int[3, 4];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine($"{i + 1} Telebenin {j + 1} qiymetini girin");
            //        int point = int.Parse(Console.ReadLine());
            //        arr2d[i, j] = point;


            //    }
            //}
            //Console.WriteLine("Telebelerin qiymeti asaqidaki kimidir");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(arr2d[i, j] + " ; ");

            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Telebelerin siyahisini daxil edin:");
            int studentCount = int.Parse(Console.ReadLine());

            string[] studentList = new string[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                string studentName = Console.ReadLine();
                studentList[i] = studentName;

            }
            Console.WriteLine("*****");

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write("Students name:"+ studentList[i] );
            //}

            foreach (var item in studentList)
            {
                Console.WriteLine(item);
            }

        }
    }
}