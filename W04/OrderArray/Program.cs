
internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhap kich thuoc mang");
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n+1];
        for (int i = 0; i < n; i++)
        {
           Console.WriteLine("Nhap phan tu mang");
           array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Mang co cac phan tu la");
        for (int i = 0; i < n; i++)
        {
           Console.Write(array[i] +"\t" );            
        }
        Console.WriteLine();
        Console.WriteLine("nhap so can chen");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap vi tri can chen");
        int p = Convert.ToInt32(Console.ReadLine());
        for (int i = n; i >= p; i--)
        {
            array[i] = array[i - 1];
        }
        array[p - 1] = x;
        for (int i = 0; i <= n; i++)
        {
            Console.Write(array[i] +"\t");
        }
    }
}