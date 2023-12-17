 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao");
            double height = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang");
            double weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2);

            bmi = Math.Round(bmi, 0);

            Console.WriteLine(bmi);
            if(bmi<18)
            {
                Console.WriteLine("Gay");
            }
            else if(bmi<25)
            {
                Console.WriteLine("Binh thuong");
            }
            else if(bmi>30)                
            {
                Console.WriteLine("Thua can");
            } 
            else if(bmi>30)
            {
                Console.WriteLine("Beo phi");
            }  
            else
            {
                Console.WriteLine("Nhap lai");
            }

        }
    }