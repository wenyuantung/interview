using System;
using System.IO;


namespace CSharpClassLibrary
{
    // Turn off Resharp or open in Notepad
    public class ExceptionTest
    {
        /*public static void Exception0()
        {
            Console.WriteLine("Calling Exception0");
            try
            {
                throw new FileLoadException("File D:\\test\\test.txt doesn't exist");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
                return;
            }           
            finally
            {
                Console.WriteLine("i am inside finally");
                Console.Read();
            }
        }*/

        public static void Exception1()
        {
            Console.WriteLine("Calling Exception1");
            try
            {
                throw new SystemException("This is wrong");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                Console.WriteLine("i am inside finally");
                Console.Read();
            }
        }

        public static void Exception2()
        {
            Console.WriteLine("Calling Exception2");
            try
            {
                throw new SystemException("This is wrong");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("i am inside finally");
                Console.Read();
            }
        }

        public static void Exception3()
        {
            Console.WriteLine("Calling Exception3");
            try
            {
                Exception32();
            }
            catch (Exception e)
            {
                throw e;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Inside Exception3 Finally");
            }
        }

        private static void Exception32()
        {
            try
            {
                throw new Exception("Exception from Excetion32");
            }
            catch (Exception e)
            {
                throw;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Inside Exception32 Finally");
            }
        }
    }
}
