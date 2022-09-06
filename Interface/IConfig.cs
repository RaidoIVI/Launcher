namespace Launcher
{
    internal interface IConfig
    {
        internal IOStream IOStream { get; }

        internal FileInfo FileOutput { get; }

    }
}
