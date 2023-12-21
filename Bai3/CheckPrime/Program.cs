
 class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot so tu ban phim");
        int number = int.Parse(Console.ReadLine());
        if(number<2)
        {
            Console.WriteLine("Khong phai la so nguyen to");
        }
        else
        {
            int i=2;
            bool check=true;
            while (i<=Math.Sqrt(number))
            {
              if(number%i==0)
              {
                check=false;
                break;
              }
              i++;  
            }
            if(check=true)
            {
                Console.WriteLine("Day la so nguyen to");

            }
            else 
            {
                Console.WriteLine("Day khong phai la so nguyen to");
            }
        }
    }
}