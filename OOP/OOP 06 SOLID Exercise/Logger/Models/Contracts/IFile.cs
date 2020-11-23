namespace Logger.Models.Contracts
{
    public interface IFile
    {
        public string Path { get; }
        long Size { get; }
        public string Write(ILayout layout, IError error);
    }
}
