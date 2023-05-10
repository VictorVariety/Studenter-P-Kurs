namespace Klassetrening;

public class Program
{
    static bool check = true;
    static void Main(string[] args)
    {
        var students = new List<Studenter>();
        students.Add(new Studenter("Jonas", 18, "JavaScript", 1));
        students.Add(new Studenter("Geir", 19, "JavaScript", 1));
        students.Add(new Studenter("Hans", 28, "C#", 2));

        while (check)
        {
            Console.WriteLine("Velg kurs id, for å vise studenter som er på det kurset");
            var kursId = Convert.ToInt32(Console.ReadLine());

            if (students.Any(student => student.KursId == kursId)) FindStudents(students, kursId);
            else
            {
                Console.WriteLine("Kurset finnes ikke, prøv igjen");
                continue;

            }
        }
    }

    private static void FindStudents(List<Studenter> students, int kursId)
    {
        foreach (var student in students.Where(student => student.KursId == kursId))
        {
            Console.WriteLine($"Navn: {student.Navn} \nAlder: {student.Alder}");
            check = false;
        }
    }
}