using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFinallyDemo
{
    class Program
    {
        // source: https://msdn.microsoft.com/en-us/library/zwc8s4fz.aspx

        static void Main(string[] args)
        {
            int i = 123;
            string s = "Some string";
            object obj = s;

            try
            {
                // Invalid conversion; obj contains a string, not a numeric type.
                i = (int)obj;

                // The following statement is not run.
                Console.WriteLine("WriteLine at the end of the try block.");
            }
            finally
            {
                // To run the program in Visual Studio, type CTRL+F5. Then 
                // click Cancel in the error dialog.
                Console.WriteLine("\nExecution of the finally block after an unhandled\n" +
                    "error depends on how the exception unwind operation is triggered.");
                Console.WriteLine("i = {0}", i);
            }
        }


    }
}
