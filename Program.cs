using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
       string[] name = {"Lan","Giang","Nam","Chi","Linh","Thuan","Hoang"};

       Console.WriteLine("Nhap mot ten bat ky");
       
       string a = Console.ReadLine();
       bool check = false;
       for (int i = 0; i < name.Length;i++)
       {
        if (Equals(name[i],a))
        {
           Console.WriteLine("Ten da nhap co trong danh sach");
           check = true;
        }
       }

       if(!check)
       {
        Console.WriteLine("Khong co tong danh sach");
       }

        

    }

}