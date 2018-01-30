using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] EmployeeName = new string[3];
            EmployeeName[0] = "Mark";
            EmployeeName[1] = "john";
            EmployeeName[2] = "Sara";
            string[][] EmployeeArray = new string[3][];
            EmployeeArray[0] = new string[3];
            EmployeeArray[1] = new string[1];
            EmployeeArray[2] = new string[2];

            EmployeeArray[0][0] = "PHD";
            EmployeeArray[0][1] = "masters";
            EmployeeArray[0][2] = "Bachilor";

            EmployeeArray[1][0] = "masters";

            EmployeeArray[2][0] = "phd";
            EmployeeArray[2][1] = "balchilor";

            for( int i =0; i < EmployeeArray.Length; i++)

            {
                string[] innerArray = EmployeeArray[i];
                Console.WriteLine(EmployeeName[i]);
                Console.WriteLine("===========");

                for (int j=0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                    Console.ReadLine();
                }
            }
       
  
            
        }
    }
}
