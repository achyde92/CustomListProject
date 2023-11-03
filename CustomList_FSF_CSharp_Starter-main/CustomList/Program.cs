namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(8);
            list[0] = 32;

        }
    }
}