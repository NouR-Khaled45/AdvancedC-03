namespace AdvancedC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager

          
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            
            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First: {grades[0]}");
            Console.WriteLine($"Last: {grades[grades.Count - 1]}");

            
            grades.Sort();
            Console.WriteLine("Sorted: " + string.Join(", ", grades));

            
            int firstAbove90 = grades.Find(g => g > 90);
            Console.WriteLine($"First above 90: {firstAbove90}");

            
            List<int> failing = grades.FindAll(g => g < 75);
            Console.WriteLine("Failing: " + string.Join(", ", failing));

         
            int removed = grades.RemoveAll(g => g < 75);
            Console.WriteLine($"Removed {removed} failing grades: " + string.Join(", ", grades));

            
            bool has100 = grades.Contains(100);
            Console.WriteLine($"Has 100? {has100}");

          
            List<string> labels = new List<string>();
            foreach (int g in grades)
                labels.Add($"Grade: {g}");

            foreach (string label in labels)
                Console.WriteLine(label);
            #endregion
        }
    }
}
