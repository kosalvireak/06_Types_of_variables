using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_Types_of_variables
{
    internal class Program
    {
        class Phone
        {
            public string strModel;
            public float fltPrice;
            public static int intCount;
            public static float fltTotalPrice;
            public Phone(string strModel, float fltPrice)
            {
                this.strModel = strModel;
                this.fltPrice = fltPrice;
                intCount ++;
                fltTotalPrice += fltPrice;
            }
        }
        static void Main(string[] args)
        {
            Phone objP1, objP2;
            Console.Write("Enter the model: ");
            string model = Console.ReadLine();
            Console.Write("Enter the price: ");
            float price = float.Parse(Console.ReadLine());
            objP1 = new Phone(model, price);

            Console.Write("Enter the model: ");
            model = Console.ReadLine();
            Console.Write("Enter the price: ");
            price = float.Parse(Console.ReadLine());
            
            objP2 = new Phone(model, price);

            Console.WriteLine("The Phone 1 model is: {0}, and its cost: {1}", objP1.strModel, objP1.fltPrice);
            Console.WriteLine("The Phone 2 model is: {0}, and its cost: {1}", objP2.strModel, objP2.fltPrice);
            Console.WriteLine("Total Count: {0}, Total Score: {1}", Phone.intCount, Phone.fltTotalPrice);
            Console.ReadKey();
        

        }
    }
}
