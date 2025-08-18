namespace Delegates
{
    public delegate void Compute(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Compute f = new Compute(CalculateClass.Sum);
            f += CalculateClass.Multiply;
            f += CalculateClass.Sub;
            f += delegate (int x, int y)
            {
                Console.WriteLine(x/y);
            };
            f(15, 10);

            
        }
    }
}
