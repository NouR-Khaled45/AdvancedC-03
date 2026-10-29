namespace AdvancedC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Exercise 1: Student Grade Manager


            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };


            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First: {grades[0]}");
            //Console.WriteLine($"Last: {grades[grades.Count - 1]}");


            //grades.Sort();
            //Console.WriteLine("Sorted: " + string.Join(", ", grades));


            //int firstAbove90 = grades.Find(g => g > 90);
            //Console.WriteLine($"First above 90: {firstAbove90}");


            //List<int> failing = grades.FindAll(g => g < 75);
            //Console.WriteLine("Failing: " + string.Join(", ", failing));


            //int removed = grades.RemoveAll(g => g < 75);
            //Console.WriteLine($"Removed {removed} failing grades: " + string.Join(", ", grades));


            //bool has100 = grades.Contains(100);
            //Console.WriteLine($"Has 100? {has100}");


            //List<string> labels = new List<string>();
            //foreach (int g in grades)
            //    labels.Add($"Grade: {g}");

            //foreach (string label in labels)
            //    Console.WriteLine(label);
            //#endregion


            //#region Exercise 2: Leaderboard

            //SortedList<int, string> leaderboard = new SortedList<int, string>();
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");


            //Console.WriteLine("--- Leaderboard ---");
            //foreach (var entry in leaderboard)
            //    Console.WriteLine($"{entry.Key} = {entry.Value}");


            //Console.WriteLine($"First Key: {leaderboard.Keys[0]}");
            //Console.WriteLine($"First Value: {leaderboard.Values[0]}");


            //Console.WriteLine($"Score 500 exists? {leaderboard.ContainsKey(500)}");


            //if (leaderboard.TryGetValue(999, out string player))
            //    Console.WriteLine($"Score 999: {player}");
            //else
            //    Console.WriteLine("Score 999: Not found");


            //leaderboard.Remove(200);

            //foreach (var entry in leaderboard)
            //    Console.WriteLine($"{entry.Key} = {entry.Value}");
            //#endregion

            //            #region Exercise 3: Phone Book


            //            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    { "Ahmed", "01012345678" },
            //    { "Sara",  "01198765432" },
            //    { "Ali",   "01234567890" },
            //    { "Mona",  "01555555555" }
            //};


            //            phoneBook["Omar"] = "01011112222";   // Add (new key)
            //            phoneBook["Sara"] = "01100000000";   // Update (existing key)
            //            Console.WriteLine($"Omar added: {phoneBook["Omar"]}");
            //            Console.WriteLine($"Sara updated: {phoneBook["Sara"]}");


            //            try
            //            {
            //                phoneBook.Add("Ahmed", "01099999999");
            //            }
            //            catch (ArgumentException ex)
            //            {
            //                Console.WriteLine($"Error: {ex.Message}");
            //            }


            //            bool added = phoneBook.TryAdd("Ahmed", "01099999999");
            //            Console.WriteLine($"TryAdd Ahmed succeeded? {added}");


            //            if (phoneBook.TryGetValue("Khaled", out string phone))
            //                Console.WriteLine($"Khaled: {phone}");
            //            else
            //                Console.WriteLine("Khaled is not in the phone book");


            //            string result = phoneBook.GetValueOrDefault("Khaled", "Not Found");
            //            Console.WriteLine($"Khaled: {result}");


            //            Console.WriteLine("Names: " + string.Join(", ", phoneBook.Keys));
            //            Console.WriteLine("Phones: " + string.Join(", ", phoneBook.Values));
            //            #endregion

            //#region Exercise 4: Unique Email Validator

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);


            //Console.WriteLine($"Add ahmed@test.com: {emails.Add("ahmed@test.com")}");
            //Console.WriteLine($"Add AHMED@test.com: {emails.Add("AHMED@test.com")}");
            //Console.WriteLine($"Add sara@test.com: {emails.Add("sara@test.com")}");
            //Console.WriteLine($"Add Sara@Test.Com: {emails.Add("Sara@Test.Com")}");

            //Console.WriteLine($"Count: {emails.Count}");
            //Console.WriteLine("Stored: " + string.Join(", ", emails));
            //Console.WriteLine();

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };


            //// UnionWith -> all elements from A and B (no duplicates)
            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine("Union: " + string.Join(", ", union));

            //// IntersectWith -> only elements found in BOTH A and B
            //HashSet<int> intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);
            //Console.WriteLine("Intersect: " + string.Join(", ", intersect));

            //// ExceptWith -> elements in A that are NOT in B
            //HashSet<int> except = new HashSet<int>(setA);
            //except.ExceptWith(setB);
            //Console.WriteLine("Except: " + string.Join(", ", except));


            //HashSet<int> small = new HashSet<int> { 1, 2 };
            //Console.WriteLine( small.IsSubsetOf(setA));
            //#endregion

            #region Exercise 5: Print Queue Simulator
            
            Queue<string> printQueue = new Queue<string>();
            printQueue.Enqueue("Report.pdf");
            printQueue.Enqueue("Invoice.pdf");
            printQueue.Enqueue("Letter.docx");
            printQueue.Enqueue("Resume.pdf");
            printQueue.Enqueue("Photo.jpg");

            Console.WriteLine("Queue: " + string.Join(", ", printQueue));
            Console.WriteLine($"Count: {printQueue.Count}");

            Console.WriteLine($"Next to print: {printQueue.Peek()}");
            Console.WriteLine($"Count after Peek: {printQueue.Count}"); // still 5

            
            
            while (printQueue.Count > 0)
            {
                string doc = printQueue.Dequeue();
                Console.WriteLine($"Printing: {doc}");
            }
            Console.WriteLine($"Count after printing: {printQueue.Count}");

           // returns false, no exception
            if (printQueue.TryDequeue(out string nextDoc))
                Console.WriteLine($"Printing: {nextDoc}");
            else
                Console.WriteLine(" Queue is empty, nothing to print");
            #endregion


            #region Exercise 6: Browser History (Undo)
         
            Stack<string> history = new Stack<string>();

            
            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");

            
            Console.WriteLine("History: " + string.Join(", ", history));

            
            Console.WriteLine($"Current page: {history.Peek()}");

          
            for (int i = 0; i < 3; i++)
            {
                string leftPage = history.Pop();
                Console.WriteLine($"Back: leaving {leftPage}");
            }

            
            Console.WriteLine($"Current page: {history.Peek()}");

           
            history.Clear();
            Console.WriteLine($"Count after Clear: {history.Count}");

            if (history.TryPop(out string page))
                Console.WriteLine($"Popped: {page}");
            else
                Console.WriteLine(" Stack is empty, no page to go back to");
            #endregion
        }
    }
}
