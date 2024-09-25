namespace EsraaAtef_sun_wed_5PM_C_5
{
    #region Q1
    //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
    /// <summary>
    /// /Then, write a C# program that prints out all the days of the week using this enum.
    /// </summary>

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }


    #endregion

    #region Q2
    //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
    //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
    //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    #endregion

    #region Q3
    //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
    // 
    // Create Variable from previous Enum to Add and Remove Permission from variable,
    // check if specific Permission is existed inside variable
    [Flags]
    enum Permission : byte
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
    }



    #endregion

    #region Q4
    // Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
    //Write a C# program that takes a color name as input from the user and displays a message
    //indicating whether the input color is a primary color or not.
  

    enum Colors
    {
        Red,
        Green,
        Blue,
    }


    #endregion

  
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            //    Console.WriteLine( day);
            #endregion

            #region Q2
            // Console.WriteLine("Enter a season name (Spring,Summer,Autumn,Winter): ");

            // string season = Console.ReadLine();

            //if(Enum.TryParse(season,out Season inputseason))
            // {
            //     switch (inputseason)
            //     {
            //         case Season.Spring:
            //             Console.WriteLine("Month Range : march to may");
            //             break;
            //         case Season.Summer:
            //             Console.WriteLine("Month Range : june to augest");
            //             break;
            //         case Season.Autumn:
            //             Console.WriteLine("Month Range : sep to Nov");
            //             break;
            //         case Season.Winter:
            //             Console.WriteLine("Month Range : Dec to feb");
            //             break;
            //         default:
            //             Console.WriteLine("Invalid Season");
            //             break;
            //     }
            // }
            #endregion

            #region Q3

            //Permission Perm, InputPerm, FPerm;
            //Console.WriteLine("Please Enter a permission :");
            //Enum.TryParse(Console.ReadLine(), true, out Perm);

            //while (true)
            //{
            //    Console.WriteLine("do u want  add or delete a permission :");
       
            //    Enum.TryParse(Console.ReadLine(), out InputPerm);

            //    Perm ^= InputPerm; 

            //    Console.WriteLine("Do you want to add or delete more  (Y , N):");

            //    if (Console.ReadLine() == "N")
            //        break;


            //}

            //Console.WriteLine("Write Permission name that you want to find :");
            //Enum.TryParse(Console.ReadLine(), out FPerm);


            //if ((Perm & FPerm) == FPerm)
            //{
            //    Console.WriteLine("Permission is found");
            //}
            //else
            //    Console.WriteLine("Permission is not not found");
            #endregion

            #region Q4
            //Console.WriteLine("Enter color:");
            //bool found = Enum.TryParse(Console.ReadLine(), true, out Colors color);

            //if (found)
            //    Console.WriteLine("Color is a Primary ");
            //else
            //    Console.WriteLine("Color is not a Primary");

            #endregion









        }
    }
}
