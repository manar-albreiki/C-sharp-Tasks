using System.IO;
//using static System.Net.WebRequestMethods;
using System.Diagnostics;
namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Practice
            //Console.WriteLine("Hello, World!");
            ////File.Create("test01.txt");
            //String[] cities =
            //{
            //    "muscat",
            //    "London",
            //    "NewYork",
            //    "Rome"

            //};
            //File.AppendAllLines("test01.txt", cities);
            //File.AppendAllText("test01.txt", "\n Paris");
            #endregion

            #region task01
            try
            {
                //File.Create("exam01.txt");
                //File.Create("exam02.txt");
                //File.Create("exam03.txt");
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                File.AppendAllText("exam01.txt", "\nThis is exam01");
                File.AppendAllText("exam02.txt", "\nThis is exam02");
                File.AppendAllText("exam03.txt", "\nThis is exam03");

                Console.WriteLine("Write the exam number");
                int exam = Convert.ToInt32(Console.ReadLine());

                if (exam == 1)
                {
                    System.Diagnostics.Process.Start("notepad.exe", "exam01.txt");
                }
                else if (exam == 2)
                {
                    System.Diagnostics.Process.Start("notepad.exe", "exam02.txt");
                }
                else if (exam == 3)
                {
                    System.Diagnostics.Process.Start("notepad.exe", "exam03.txt");
                }
                else
                {
                    Console.WriteLine("write the correct exam number");
                }
            }
            #endregion
        }
    }
}
