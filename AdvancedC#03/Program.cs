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


            #region Exercise 2: Leaderboard

            SortedList<int, string> leaderboard = new SortedList<int, string>();
            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            
            Console.WriteLine("--- Leaderboard ---");
            foreach (var entry in leaderboard)
                Console.WriteLine($"{entry.Key} = {entry.Value}");

           
            Console.WriteLine($"First Key: {leaderboard.Keys[0]}");
            Console.WriteLine($"First Value: {leaderboard.Values[0]}");

            
            Console.WriteLine($"Score 500 exists? {leaderboard.ContainsKey(500)}");

        
            if (leaderboard.TryGetValue(999, out string player))
                Console.WriteLine($"Score 999: {player}");
            else
                Console.WriteLine("Score 999: Not found");

            
            leaderboard.Remove(200);
           
            foreach (var entry in leaderboard)
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            #endregion
        }
    }
}
