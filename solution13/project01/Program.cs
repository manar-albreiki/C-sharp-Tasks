using System.Xml.Linq;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region stack

            Stack<string> names = new Stack<string>();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine();
                names.Push(name);
            }
            Console.WriteLine("----------------------");
            foreach (string x in names)
            {
                Console.WriteLine(x);
            }
            while (true)
            {

                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Add name");
                Console.WriteLine("2- Print the first element");
                Console.WriteLine("3- Delet");
                Console.WriteLine("4- Display all element");
                Console.WriteLine("5- Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter new name:");
                    string newName = Console.ReadLine();
                    names.Push(newName);

                }
                else if (choice == 2)
                {
                    Console.WriteLine(names.Peek());
                }
                else if (choice == 3)
                {
                    names.Pop();
                    Console.WriteLine("the element has been deleted");
                }
                else if (choice == 4)
                {
                    foreach (string name in names)
                    {

                        Console.WriteLine(name);
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("enter the correct number");
                }
            }
            #endregion
        }
    }
}
