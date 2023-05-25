using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCurrentValue {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("#### Input the basic information for the trade below ####");
            
            Console.WriteLine("Nominal Amount:");           
            int nominal = 0;
            if (!Int32.TryParse(Console.ReadLine(), out nominal)) {
                Console.WriteLine("Norminal amount need to be an integer number, try again:");
                nominal = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Buy or Sell?");          
            TransactionType BorS =(TransactionType)Enum.Parse(typeof(TransactionType), Console.ReadLine(),true);
            int sign = BorS == TransactionType.Buy ? 1 : -1;
           //Realized PL is only calculated for Sell transaction, for Buy transation it is 0
            int plFactor = BorS == TransactionType.Sell ? 1: 0;

            Console.WriteLine("Traded Price:");
            var tradePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Oringinal investment Price:");
            var originalPrice = float.Parse(Console.ReadLine());

            //Calculate current value
            var currentValue = sign * nominal * tradePrice;
            Console.WriteLine($"{BorS.ToString()} "+$"{nominal} trade "+$"with traded price = {tradePrice} means you will have to pay "+$"{currentValue} for the current value.");
            //Calculate P&L for Sell transactions
            var PL = plFactor * (tradePrice - originalPrice) * nominal;
            Console.WriteLine($"You realized PL is: {PL}");

            Console.ReadKey();
        }

        private enum TransactionType { Buy, Sell };
        
    }

}
