namespace SyntaxAndSyntaxSugarExercise
{
    internal class Program
    {
        public static string MyAnswer()
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal to nine";
            return response;
        }
        static void Main(string[] args)
        {
            var answer = 4;
            Console.WriteLine($"My son is {answer} years old and understands that there are {answer} tires on dad's car");
            Console.WriteLine(MyAnswer());

        }
    }
}