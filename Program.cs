using System;

namespace switch_Case
{
    class Program
    {
        static void Main(string[] args)
      {
        int month = DateTime.Now.Month;

        switch (month) //expression
        {
            case 1:
            Console.WriteLine("Ocak ayındasınız");
            break;

            case 2:
            Console.WriteLine("Subat ayındasınız");
            break;

            case 4:
            Console.WriteLine("Nisan ayındasınız");
            break;

            case 3:
            Console.WriteLine("Mart ayındasınız");
            break;
            
            default:
            Console.WriteLine("Yanlış veri girişi!");
            break;
        }

        switch(month)
     {
        case 12:
        case 1:
        case 2:
        Console.WriteLine("Kış ayındasınız");
        break;

        case 6:
        case 7:
        case 8:
        Console.WriteLine("Yaz ayındasınız");
        break;

        default:
        break;

     }
        }
    }
}

