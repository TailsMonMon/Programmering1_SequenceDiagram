using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_SequenceDiagram {
    class Program {
        static void Main(string[] args) {
            var age = 0; // Defining data.

            //  INPUT
            do {
                Console.Write("Enter age: ");
                try {
                    age = Convert.ToInt32(Console.ReadLine()); // Converts the input string to an int.
                }
                catch(FormatException) {
                    Console.WriteLine("Please write an integer."); // Error message
                    Console.WriteLine();
                }
            } while(age == 0); // When age is chaged from 0. The program will continue.

            int money = 15000; // Defining data.

            do {
                if(age < 60 || money > 20000) {
                    Console.WriteLine("You are saving a little."); //FIXME sic.
                    money += 500; // Adds 500 to money.
                }
                else {
                    Console.WriteLine("You are saving a lot");
                    money += 1000; // Adds 1000 to money.
                }

                age++; // Adds 1 to age.
            } while(money < 20000 && age < 65); // While money is less than 20 000 AND age is less than 65

            //  OUTPUT
            Console.WriteLine("You are retired by the age of {0}.", age);
            Console.WriteLine("You are saved {0} dollars.", money); // FIXME sic.
            Console.ReadKey();
        }
    }
}
