using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06Exercises02
{
    internal class Program
    {
        class Patient
        {
            public string strPatientName;
            public float fltFees;
            private static int intTotalPatients;
            private static float fltTotalFees;
            public static int returnintTotalPatients()
            {
                return Patient.intTotalPatients;
            }
            public static float returnfltTotalFees()
            {
                return Patient.fltTotalFees;
            }
            public Patient(string strPatientName, float fltFees)
            {
                this.strPatientName = strPatientName;
                this.fltFees = fltFees;
                intTotalPatients ++;
                fltTotalFees += fltFees;

            }
        }
        static void Main(string[] args)
        {
            Patient objPatient1, objPatient2;
            Console.Write("Enter the name of patient 1: ");
            string name = Console.ReadLine();
            Console.Write("Enter the fee of patient 1: ");
            float fee = float.Parse(Console.ReadLine());
            objPatient1 = new Patient(name, fee);

            Console.Write("Enter the name of patient 2: ");
            name = Console.ReadLine();
            Console.Write("Enter the fee of patient 2: ");
            fee = float.Parse(Console.ReadLine());
            objPatient2 = new Patient(name, fee);

            Console.WriteLine("The patient 1 is : {0}, and their fee {1}", objPatient1.strPatientName, objPatient1.fltFees);
            Console.WriteLine("The patient 2 is : {0}, and their fee {1}", objPatient2.strPatientName, objPatient2.fltFees);
            Console.WriteLine("Number of patient {0}, total fee{1}, ",Patient.returnintTotalPatients(), Patient.returnfltTotalFees());
            Console.ReadKey();
        }
    }
}
