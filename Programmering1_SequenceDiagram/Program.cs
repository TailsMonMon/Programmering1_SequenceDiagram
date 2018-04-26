using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_SequenceDiagram {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int money = 15000;

            do {
                if(age < 60 || money > 20000) {
                    Console.WriteLine("You are saving a little."); //FIXME sic.
                    money += 500;
                }
                else {
                    Console.WriteLine("You are saving a lot");
                    money += 1000;
                }

                age++;
            } while(money < 20000 && age < 65);

            Console.WriteLine("You are retired by the age of {0}.", age);
            Console.WriteLine("You are saved {0} dollars.", money); // FIXME sic.
            Console.ReadKey();
        }
    }
}
