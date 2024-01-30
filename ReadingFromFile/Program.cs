namespace Lab2Review;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello world");
        string[] students = File.ReadAllLines("C:\\Users\\msouc\\source\\repos\\ReadingFromFile\\ReadingFromFile\\TextFile1.txt");
        foreach (string student in students)
        {
            Console.WriteLine(student);
            string[] studentData = student.Split(',');
            foreach(string data in studentData)
            {
                Console.WriteLine(data);
            }
        }
    }
}
