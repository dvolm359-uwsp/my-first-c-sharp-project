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
    class InvoiceCalculator {
        // constants
        public const decimal DEFAULT_SUBTOTAL = 0.00m;


        // private properties
        private int discountPercent { get {
            if(Subtotal >= 300) {
                return 30;
            } else if (Subtotal >= 200) {
                return 20;
            } else if (Subtotal >= 100) {
                return 10;
            } else {
                return 0;
            }
        } }
        private decimal discountAmount { get {
            return Subtotal * ( (decimal)discountPercent / (decimal)100 );
        } }


        // public properties
        public string DiscountPercent { get {
            return $"{discountPercent}.0 %";
        } }

        public decimal Subtotal { get; set; }

        public string DiscountAmount { get {
            return $"${string.Format("{0:0.00}", discountAmount)}";
        } }

        public string Total { get {
            return $"${string.Format("{0:0.00}", Subtotal - discountAmount)}";
        } }


        // constructor
        public InvoiceCalculator(
            decimal _subtotal = DEFAULT_SUBTOTAL
        ) {
            Subtotal = _subtotal;
        }


        // public methods
        public void parseAndSetSubtotal(string subtotal, Action success, Action fail) {
            try {
                Subtotal = Convert.ToDecimal(subtotal);
                success();
            } catch (Exception) {
                fail();
            }
        }
    }
}
