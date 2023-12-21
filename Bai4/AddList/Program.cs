
 class Program
{
    private static void Main(string[] args)
    {
        
      int winterList=0; 
      int[] myList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
       Console.WriteLine("Tong cua mang la");
      for  (int i = 0; i <= myList.Length-1; i++)
       {
        winterList += myList[i];        
       }
       Console.WriteLine(winterList);



    }
}