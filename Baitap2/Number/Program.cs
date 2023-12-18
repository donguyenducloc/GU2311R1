
class Program
{
    private static void Main(string[] args)
    {
       //Nhap mot so tu ban phim
       Console.WriteLine("Nhap mot so tu bann phim ");
       int cout = int.Parse(Console.ReadLine());
       Console.WriteLine(cout);
       if(cout<10)
        {
          switch(cout)
          {
            case 0: Console.WriteLine("Khong");
            break;
            case 1: Console.WriteLine("Mot");
            break;
            case 2: Console.WriteLine("Hai");
            break;
            case 3: Console.WriteLine("Ba");
            break;
            case 4: Console.WriteLine("Bon");
            break;
            case 5: Console.WriteLine("Nam");
            break;
            case 6: Console.WriteLine("Sau");
            break;
            case 7: Console.WriteLine("Bay");
            break;
            case 8: Console.WriteLine("Tam");
            break;
            case 9: Console.WriteLine("Chin");
            break;
          }  
        }
        else if(cout<20)
        {
            int chuc = (int) cout/10;
            int dv   = (int) cout%10;
            Console.Write("Muoi ");
            switch(dv)
          {
            case 1: Console.WriteLine("Mot");
            break;
            case 2: Console.WriteLine("Hai");
            break;
            case 3: Console.WriteLine("Ba");
            break;
            case 4: Console.WriteLine("Bon");
            break;
            case 5: Console.WriteLine("Nam");
            break;
            case 6: Console.WriteLine("Sau");
            break;
            case 7: Console.WriteLine("Bay");
            break;
            case 8: Console.WriteLine("Tam");
            break;
            case 9: Console.WriteLine("Chin");
            break;
          }
        }
        else if(cout<100)
        {
           int chuc = (int) cout/10;
            int dv   = (int) cout%10;
            switch(chuc)
          {
            case 2: Console.Write("Hai");
            break;
            case 3: Console.Write("Ba");
            break;
            case 4: Console.Write("Bon");
            break;
            case 5: Console.Write("Nam");
            break;
            case 6: Console.Write("Sau");
            break;
            case 7: Console.Write("Bay");
            break;
            case 8: Console.Write("Tam");
            break;
            case 9: Console.Write("Chin");
            break;
          }
          Console.Write(" Muoi ");
            switch(dv)
          {
            case 1: Console.WriteLine("Mot");
            break;
            case 2: Console.WriteLine("Hai");
            break;
            case 3: Console.WriteLine("Ba");
            break;
            case 4: Console.WriteLine("Bon");
            break;
            case 5: Console.WriteLine("Nam");
            break;
            case 6: Console.WriteLine("Sau");
            break;
            case 7: Console.WriteLine("Bay");
            break;
            case 8: Console.WriteLine("Tam");
            break;
            case 9: Console.WriteLine("Chin");
            break;
          }

        }

    }
 }
