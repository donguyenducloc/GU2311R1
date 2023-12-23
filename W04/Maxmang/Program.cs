
 class Program
{
    private static void Main(string[] args)
    {
        int size=0;
        do
        {
            Console.WriteLine("Nhap kich thuoc mang");
            size = int.Parse(Console.ReadLine());
            if(size>20) Console.WriteLine("Gia tri nhap qua 20 yeu cau nhap lai");                
        }while (size>20);
        int[] array = new int[size];
        Console.WriteLine("Nhap phan tu cua mang");
        for (int i = 0; i <=array.Length-1; i++)
        {
           array[i]= int.Parse(Console.ReadLine()); 
        }
        Console.WriteLine("Gia tri cac phan tu cua mang la:");
        for (int i = 0; i <=array.Length-1; i++)
        {
          Console.Write(array[i]+"\t");  
        }
        int max = array[0];
        int indextArrayList=0;
        for (int i = 0; i <= array.Length-1 ; i++)
        {
           if(array[i]>max) 
           {
             max = array[i];
             indextArrayList = i+1;
           }

        }
         Console.WriteLine("Gia tri lon nhat la "+ max + " co vi tri "+ indextArrayList);
    }
}