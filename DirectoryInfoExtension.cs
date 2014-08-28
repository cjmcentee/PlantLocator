using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlantLocator
{
    public static class DirectoryInfoExtension
    {
        public static IEnumerable<DirectoryInfo> FindStateFileFolders(this DirectoryInfo parentDirectory)
        {
            var childDirectories =
                from directoryName in Directory.EnumerateDirectories(parentDirectory.FullName, "*", SearchOption.AllDirectories)
                let directory = new DirectoryInfo(directoryName)
                where directory.HasStateFiles()
                select directory;
            
            return childDirectories;
        }

        public static bool HasStateFiles(this DirectoryInfo directory)
        {
            Regex StateFilePattern = new Regex(@"conveyor\.safedomains\.Lane\d_\d\.state");

            var fileNames = Directory.EnumerateFiles(directory.FullName);

            foreach (string fileName in fileNames)
                if (StateFilePattern.IsMatch(fileName))
                    return true;

            return false;
        }

        public static IEnumerable<FileInfo> StateFiles(this DirectoryInfo directory)
        {
            Regex StateFilePattern = new Regex(@"conveyor\.safedomains\.Lane\d_\d\.state");
            
            var stateFiles =
                from fileName in Directory.EnumerateFiles(directory.FullName)
                where StateFilePattern.IsMatch(fileName)
                let stateFile = new FileInfo(fileName)
                select stateFile;

            return stateFiles;
        }
    }
}
