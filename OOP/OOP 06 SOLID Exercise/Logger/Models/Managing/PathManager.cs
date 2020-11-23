
using Logger.Models.Contracts;
using System.IO;

namespace Logger.Models.Managing
{
    public class PathManager : IPathManager
    {
        private string currentPath;
        private string folderName;
        private string fileName;
        private PathManager()
        {
            this.currentPath = this.GetCurrentPath();
        }
        public PathManager(string folderName, string fileName):this()
        {
            this.folderName = folderName;
            this.fileName = fileName;
        }
        public string CurrentDirectoryPath => Path.Combine(this.currentPath,this.folderName);

        public string CurrentFilePath => Path.Combine(this.CurrentDirectoryPath,this.fileName);

        public void EnsureDirectoryAndFileExist()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath))
            {
                Directory.CreateDirectory(this.CurrentDirectoryPath);
            }
            File.AppendAllText(this.CurrentFilePath, string.Empty);
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
