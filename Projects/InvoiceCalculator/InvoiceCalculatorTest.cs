/* ================================================
 * @author     David Volm aka VOLMINATOR aka daXXog
 * @date       Sun Mar  6 13:09:22 CST 2022
 * @school     UWSP
 * @class      CIS 340
 * @section    01
 * @assignment 04
 * @professor  Hardeep Kaur Dhalla
 * @licence    MIT
 * ===============================================*/

using System;


namespace InvoiceCalculator {
    class InvoiceCalculatorTest {
        static void Main(string[] args) {
            InvoiceCalculator calc = new InvoiceCalculator();
            System.Console.WriteLine("test!");
            System.Console.WriteLine(calc);
            calc.parseAndSetSubtotal("123a", () => {
                System.Console.WriteLine("okay");
            }, () => {
                System.Console.WriteLine("fail");
            });
            calc.parseAndSetSubtotal("123.456", () => {
                System.Console.WriteLine("okay");
            }, () => {
                System.Console.WriteLine("fail");
            });
            System.Console.WriteLine(calc.Subtotal);

            calc.parseAndSetSubtotal("250", () => {
                System.Console.WriteLine("okay");
            }, () => {
                System.Console.WriteLine("fail");
            });

            System.Console.WriteLine(calc.Subtotal);
            System.Console.WriteLine(calc.DiscountPercent);
            System.Console.WriteLine(calc.DiscountAmount);
            System.Console.WriteLine(calc.Total);
        }
    }
}
