namespace Launcher
{
    internal static class IO
    {
        static IO()
        {
            Init();
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

        private static void Init()
        {
            var config = new FileInfo("Laucher.cfg");
            if (!config.Exists)
            {
                Default();
            }
            else
            {
                LoadConfig(config);
            }
        }

        private static void LoadConfig(FileInfo config)
        {
            throw new NotImplementedException();
        }

        private static void Default()
        {
            throw new NotImplementedException();
        }
    }
}
