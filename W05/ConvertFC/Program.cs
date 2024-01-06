class Program
{
    private static void Main(string[] args)
    {
        int choice = -1;
        while (choice!=0)
        {
         Console.WriteLine("Nhap lua chon");
         choice = int.Parse(Console.ReadLine());
        
            switch (choice)
            {
               
                case 1:
                {
                    Console.WriteLine(celsiusToF());
                }
                break;

                 case 2:
                {
                    Console.WriteLine(FsangC());
                }
                break;

                 case 0:
                {
                    Environment.Exit(0);
                }
                break;
                default:
                {
                    Console.WriteLine("nhap lai");
                }
                break;
            }
        }

    }
    static double celsiusToF()
    {
         Console.WriteLine("nhap do C");
         int celsius = int.Parse(Console.ReadLine());
         double doF     = 9/5 * celsius+32;
         Console.WriteLine(doF);
         return doF;
    }
    static double FsangC()
    {
         Console.WriteLine("nhap do F");
                    int doF = int.Parse(Console.ReadLine());
                    int celsius = 5/9 * (doF-32);
                    Console.WriteLine(doF);
                    return celsius;
    }

}   

    