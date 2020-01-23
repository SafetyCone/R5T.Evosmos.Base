using System;


namespace R5T.Evosmos
{
    public interface ITemporaryDirectoryFilePathProvider
    {
        string GetTemporaryDirectoryFilePath(string fileName);
    }
}
