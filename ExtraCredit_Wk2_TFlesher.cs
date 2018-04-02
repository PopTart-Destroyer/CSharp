using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{

    public class Compute_Product
    {
        private int value1;
        private int value2;
        public int Value2
        {
            get { return value2; }
            set { value2 = value; }
        }

        public Compute_Product(int v1)
        {
            value1 = v1;
        }

        public void display_product_calc()
        {
            Console.WriteLine("The product is {0}", value1 * Value2);
        }
    }

    class ExtraCredit_Wk2_TFlesher
    {
        public static void Main(string[] args)
        {
            int myValue1 = 5;
            Compute_Product myproduct = new Compute_Product(myValue1);

            myproduct.Value2 = 10;

            myproduct.display_product_calc();

            Console.WriteLine();
        }
    }

}
