using System;

namespace UsingCurrent
{
 class Program
 {
     static void Main(string[] args)
    {
       Console.WriteLine("Nhap ty gia");
       float usd = float.Parse(Console.WriteLine());
       Console.WriteLine("Nhap So USD ban co:");
       float myUsd = float.Parse(Console.WriteLine());
       Console.WriteLine("Nhap So tien viet ban co sau khi doi la:"+ usd*myUsd);
       
    }

 }
}