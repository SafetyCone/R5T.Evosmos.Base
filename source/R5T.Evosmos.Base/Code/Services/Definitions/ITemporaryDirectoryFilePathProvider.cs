using System;using R5T.T0064;


namespace R5T.Evosmos
{[ServiceDefinitionMarker]
    public interface ITemporaryDirectoryFilePathProvider:IServiceDefinition
    {
        string GetTemporaryDirectoryFilePath(string fileName);
    }
}
