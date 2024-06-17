namespace OcenkiTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of students: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Number of subjects: ");
            int n = int.Parse(Console.ReadLine());
            double[,] a = new double[m, n+1];

            for (int row = 0; row < m; row++)
            {
                a[row, 0] = row + 1;
                double student = a[row, 0];
                Console.WriteLine($"Student {student}");
                for (int col = 1; col <= n; col++)
                {
                    try
                    {
                        Console.Write($"Grade {col}:");
                        a[row, col] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        a[row, col] = 0;
                    }
                }
            }

            double studentAvg = 0;
            double subjectAvg = 0;
            double classAvg = 0;

            for (int row = 0;row < m; row++)
            {
                int subjectsNum = n;
                double student = a[row, 0];
                for (int col = 1; col <= n; col++)
                {
                    if (a[row,col] == 0)
                    {
                        subjectsNum--;
                    }
                    else
                    {
                        studentAvg += a[row, col];
                        ;
                    }
                
                }
                studentAvg /= subjectsNum;
                classAvg += studentAvg;
                Console.WriteLine($"Student {student} avg: {studentAvg}");
                studentAvg = 0;
            }

            for (int col = 1; col <= n; col++)
            {
                int studentsNum = m;
                for (int row = 0; row < m; row++)
                {
                    if (a[row,col] == 0)
                    {
                        studentsNum --;
                    }
                    else
                    {
                        subjectAvg += a[row,col];
                    }
                }
                subjectAvg /= studentsNum;
                Console.WriteLine($"Average in subject {col}: {subjectAvg}");
                subjectAvg = 0;
            }

            classAvg /= m;
            Console.WriteLine($"Class average: {classAvg}");
        }
    }
}

