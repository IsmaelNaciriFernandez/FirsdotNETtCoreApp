// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirstCoreApp.Learning
{
    class TryCatchTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            try
            {
                int userNumber = int.Parse(userInput);
            }
            catch (Exception e)
            {
                if (e is FormatException)
                {
                    Console.WriteLine("Error while formatting, please enter a correct number next time.");
                    Utils.Utils.HandleExceptions(e);
                }
                else if (e is OverflowException)
                {
                    Console.WriteLine("The number was too long or short for an Int32");
                    Utils.Utils.HandleExceptions(e);
                }
                else if (e is ArgumentNullException)
                {
                    Console.WriteLine("ArgumentNull Exception, the value was empty(null)");
                    Utils.Utils.HandleExceptions(e);
                }

            }
            finally
            {
                Console.WriteLine("This is always called from the finally block");

            }
        }
    }
}
