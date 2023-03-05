namespace Assigment_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            int len;
            Console.Write("Say-i Daxil Edin: ");
            if (!int.TryParse(Console.ReadLine(), out len) || len < 0)
            {
                Console.WriteLine("Melumat Duzgun Daxil Edilmemisdir!");
                goto l1;
            }
            Student[] students = new Student[len];
            for (int i = 0; i < len; i++)
            {
                Student student = new Student();
                Console.Write($"{i + 1}.Name:");
                student.name = Console.ReadLine();
                Console.Write($"{i + 1}.Surname:");
                student.surname = Console.ReadLine();
                Console.Write($"{i + 1}.Age:");
                student.age = Console.ReadLine();
                Console.Write($"{i + 1}.Speciality:");
                student.speciality = Console.ReadLine();
                Console.Write($"{i + 1}.GroupNo:");
                student.groupNo = Console.ReadLine();
                students[i] = student;

            }
            Console.WriteLine("==========================");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(students[i]);

            }

        }
    }
}