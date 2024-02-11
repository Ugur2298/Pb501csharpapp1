using System.Text;

namespace ref_ve_out_islemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Calculation Area Of Figure");
            Console.WriteLine("2.Calculation Perimeter of Figure");
            Console.WriteLine("3. Exit");
            int requirementOfMenu=0;
            GetMenuInfo(ref requirementOfMenu);
         
        }

        public static void GetMenuInfo(ref int requirementOfMenu) 
        {
            
            do
            {
                requirementOfMenu= int.Parse(Console.ReadLine());
                if (requirementOfMenu==1)
                {
                    SubMenuRequirement();

                    int CalculateSquare = int.Parse(Console.ReadLine());
                    if (CalculateSquare == 1)
                    {
                        Console.WriteLine("Terefi daxil edin:");
                        int sideLength = int.Parse(Console.ReadLine());
                        CalculatePerimeterOfSquare(ref sideLength);

                    }

                }
                else if (requirementOfMenu == 2)
                {

                    SubMenuRequirement();
                }
                else if (requirementOfMenu == 3)
                {
                    Console.Write("Do you want to exit program: (Y-yes/N-no) ");
                    char c = char.Parse(Console.ReadLine());
                    if (char.ToLower(c)=='y')
                    {
                        break;
                    }
                    else if (char.ToLower(c) == 'n')
                    {
                        SubMenuRequirement();

                        Console.WriteLine("Please choose an option:");
                        int newRequirement = int.Parse(Console.ReadLine());
                        if (newRequirement==1)
                        {
                            SubMenuRequirement();
                        }
                         else if (newRequirement == 2)
                        {
                            SubMenuRequirement();
                            
                         }
                        else
                        {
                            break;
                        }
                    }
                    

                }

            } while (requirementOfMenu>3);
      
        }


        public static int CalculatePerimeterOfSquare(ref int sideLength) 
        {
            int result = 4 * sideLength;
            Console.WriteLine("Kvadratin perimetri: "+ result);
            return result;
        }

        public static void SubMenuRequirement() 
        {
            StringBuilder menuPageRequirement = new StringBuilder();
            menuPageRequirement.AppendLine("1.Square");
            menuPageRequirement.AppendLine("2.Circle");
            menuPageRequirement.AppendLine("3.Rectangle");
            menuPageRequirement.AppendLine("4.Triangle");
            menuPageRequirement.AppendLine("5.Triangle");
            Console.WriteLine(menuPageRequirement);
        }
    }
}