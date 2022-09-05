namespace Launcher
{
    internal static class IO
    {
        static ushort outStream;

        internal static void SetOuput(int value)
        {

        }

        internal static string Get(string Description)
        {
            Console.Write($"{Description} ");
            var tmp = Console.ReadLine();
            if (tmp == null) tmp = String.Empty;
            return tmp;
        }

        internal static void Send(string value = "")
        {
            Console.Write(value);
        }

        internal static void SendLine(string value = "")
        {
            Console.WriteLine(value);
        }
    }
}
