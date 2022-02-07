namespace Alekseeva_Homework_Lesson1
{
    internal class ProgramBase
    {
        public int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
    }
}