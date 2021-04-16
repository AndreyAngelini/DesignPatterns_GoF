using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentsRecords = new SortedList();
            studentsRecords.Add("Maria");
            studentsRecords.Add("João");
            studentsRecords.Add("Andrey");
            studentsRecords.Add("Marta");
            studentsRecords.Add("Lucas");
            studentsRecords.Add("Davi");

            studentsRecords.SetSortStrategy(new QuickSort());
            studentsRecords.Sort();

            studentsRecords.SetSortStrategy(new ShellSort());
            studentsRecords.Sort();

            studentsRecords.SetSortStrategy(new MergeSort());
            studentsRecords.Sort();

            Console.ReadKey();

        }
    }
}
