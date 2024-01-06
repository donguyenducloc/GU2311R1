
 class Program
{
    private static void Main(string[] args)
    {
        int[] array = {1,2,3,4,5,6,7,8,9,20,21};
        Console.WriteLine("gia tri nho nhat la:");
        int min = array[0];
       Console.WriteLine(MinFind(array));

    }
    static int MinFind(int[]array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]<min)
            {
                min=array[i];
            }
            
        }
        return min;
    }
}