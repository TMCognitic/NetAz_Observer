namespace DemoDelegate
{
    delegate bool Test(string s, out int i);

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Show(ints, (x) => x % 2 == 1);

        }

        private static void Show(IEnumerable<int> source, Func<int, bool> predicate)
        {
            ArgumentNullException.ThrowIfNull(predicate);

            foreach (int item in source)
            {
                if(predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}