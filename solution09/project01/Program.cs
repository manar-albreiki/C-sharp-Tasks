namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task
            //Console.WriteLine("enter number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number of columns");
            //int columns = Convert.ToInt32(Console.ReadLine());
            //int[,] numbers = new int[rows, columns];


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.WriteLine($"please enter element for ({i},{j})");
            //        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(numbers[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion



            #region part01
            //part01
            string[] students = new string[5];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("entar a names");
                students[i] = Console.ReadLine();
            }

            foreach (string elements in students)
            {
                Console.WriteLine(elements);
            }
            //part02

            int[,] grades = new int[5, 3];

            string[] subjects = { "Math", "Science", "English" };

            Console.WriteLine("Enter Students Grades:");

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"Grades for {students[x]}");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter {subjects[j]} grade: ");
                    grades[x, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // part03 - Display Grades

            Console.WriteLine("Student Grades:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{students[i]} : ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{subjects[j]} = {grades[i, j]}] ");
                }

                Console.WriteLine();
            }
            //part04
            Console.WriteLine("Student Average Grades:");
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                int avg = sum / 3;
                Console.WriteLine(avg);
            }
            //part05
            int[][] newStudents =
            {
                new int []{99,67,55},
                new int []{96,56,93,77},
                new int []{100},
                 new int []{45,90,87},
                  new int []{56,90}
            };
            for (int i = 0; i < newStudents.Length; i++)
            {
                Console.WriteLine($"Student Name: {students[i]}");

                Console.WriteLine($"Number of Subjects: {newStudents[i].Length}");

                for (int j = 0; j < newStudents[i].Length; j++)
                {
                    Console.WriteLine($"Subject {j} = {newStudents[i][j]}");
                }
            }
            //part06
            Console.WriteLine("Serach about student");
            String search = Console.ReadLine();
            int index = Array.IndexOf(students, search);
            if (index != -1)
            {
                Console.WriteLine("index of the student: " + index);
            }
            else
            {
                Console.WriteLine("Student not found");
            }

            //part07
            int highest = newStudents[0][0];

            for (int i = 0; i < newStudents.Length; i++)
            {
                for (int j = 0; j < newStudents[i].Length; j++)
                {
                    if (newStudents[i][j] > highest)
                    {
                        highest = newStudents[i][j];
                    }
                }
            }

            Console.WriteLine($"Highest Grade = {highest}");
            #endregion



        }



    }
}

