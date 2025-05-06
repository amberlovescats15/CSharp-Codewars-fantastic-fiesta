using Interview = Practice.InterviewQuestions;
using Codewars = Practice.Codewars;

namespace Practice
{
    public static class Start
    {
        private static Codewars.Main _codewars = new Codewars.Main();
        private static Interview.Main _interviewQuestions = new Interview.Main();

        public static void RunCodewars()
        {
            //var answer = _codewars.ArrayOfMultiples(7, 3);
            //Console.WriteLine(string.Join(", ", answer));

            var answer = _codewars.DuplicateCount("brandonwayne");
            Console.WriteLine(answer);

            //var answer = _codewars.Number(new List<string> { "a", "b", "c" });
            //Console.WriteLine(string.Join(",", answer));
        }

        public static void RunInterviewQuestions()
        {
            Console.WriteLine("Hello Sun");

            var test = _interviewQuestions.Reverse("brandon");
            Console.WriteLine(test);

            var test1 = _interviewQuestions.IsPalindrome("Hannah");
            Console.WriteLine(test1.ToString());
            var test2 = _interviewQuestions.IsPalindrome("Joshuah");
            Console.WriteLine(test2);
            var test3 = _interviewQuestions.IsPalindrome("Mom");
            Console.WriteLine(test3);

            var test4 = _interviewQuestions.FindSubstring("I LOVE STARBUCKS", "starbucks");
            Console.WriteLine(test4);

            var test5 = _interviewQuestions.IsPrime(6);
            Console.WriteLine(test5);
        }

    }
}
