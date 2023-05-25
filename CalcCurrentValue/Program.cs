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
                nominal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Buy or Sell?");          
            TransactionType BorS =(TransactionType)Enum.Parse(typeof(TransactionType), Console.ReadLine(),true);
            int sign = BorS == TransactionType.Buy ? 1 : -1;

            Console.WriteLine("Agreed Price:");
            var price = float.Parse(Console.ReadLine());

            //Calculate current value
            var cv = sign * nominal * price;
            Console.WriteLine($"{BorS.ToString()} "+$"{nominal} trade "+$"with agree price = {price} means you will have to pay "+$"{cv} for the current value.");
        
            Console.ReadKey();
        }

        private enum TransactionType { Buy, Sell };
        
    }

}
