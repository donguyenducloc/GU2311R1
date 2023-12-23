 class Program
{
    private static void Main(string[] args)
    {
       string[] nameList={"Loc","Tai","Thinh","Linh","Vinh","Xuan","Duong","Quy","Duom"};
       Console.WriteLine("Nhap ten mot ban");
        string name = Console.ReadLine();
        bool isTrue=false;
        for (int i = 0; i <= nameList.Length-1; i++)       
        {
           if(nameList[i].Equals(name))
           {
             Console.WriteLine($"Co ten trong mang va vi tri so {i+1}");
             isTrue=true;
             break;
           } 

            }
            if(!isTrue)
            {
                Console.WriteLine("Khong có ten");           
            }
            {
          
                 


          
        }
    }
}