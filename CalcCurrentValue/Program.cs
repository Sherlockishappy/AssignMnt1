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
            String userInput = Console.ReadLine();
            int nominal = int.Parse(userInput);

            Console.WriteLine("Buy or Sell?");          
            TransactionType BorS =(TransactionType)Enum.Parse(typeof(TransactionType), Console.ReadLine());
            int sign = BorS == TransactionType.Buy ? 1 : -1;            

            Console.WriteLine("Agreed Price:");
            var price = float.Parse(Console.ReadLine());

            var cv = sign * nominal * price;
            Console.WriteLine($"Current Value is: {cv}");

            Console.ReadKey();
        }


        private enum TransactionType { Buy, Sell };
    }

}
