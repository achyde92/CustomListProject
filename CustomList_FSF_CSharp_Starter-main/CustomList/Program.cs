namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("thing");
            list.Add("thing 2");
            list.Add("animal");
            list.Add("stuff");

            list.Remove("thing");
        }
    }
}