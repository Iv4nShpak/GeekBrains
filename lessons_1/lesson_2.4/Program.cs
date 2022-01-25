using System;
using System.Threading.Channels;

namespace lesson_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopName = "ООО \"Дом Джека\"";
            string shopAddress = "г.Москва,К.Маркса, 2А";
            string shopSite = "www.housjack.ru";
            string cashier = "Иванова И.И.";
            DateTime presentDate = DateTime.Now;
            decimal priceLatte = 500;
            decimal priceCake = 2395;
            decimal depositeMoney = 3000;
            decimal totalAmount = priceLatte + priceCake;
            decimal change = depositeMoney - totalAmount;

            Console.WriteLine(" ----------------------- ");
            Console.WriteLine($"|    {shopName}    |");
            Console.WriteLine($"| {shopAddress} |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine($"|--- {shopSite} ---|");
            Console.WriteLine("|*****КАССОВЫЙ ЧЕК******|");
            Console.WriteLine("|                       |");
            Console.WriteLine($"|1.ЛАТТЕ.........{priceLatte}руб.|");
            Console.WriteLine($"|1.Торт\"Весна\"..{priceCake}руб.|");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine($"|ИТОГ           {totalAmount}руб.|");
            Console.WriteLine($"|Наличные       {depositeMoney}руб.|");
            Console.WriteLine($"|Сдача           {change}руб.|");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine($"|Кассир:{cashier}    |");
            Console.WriteLine("|                       |");
            Console.WriteLine($"|  {presentDate}  |");
            Console.WriteLine(" ----------------------- ");
            
            Console.ReadKey();
        }
        
    }
}