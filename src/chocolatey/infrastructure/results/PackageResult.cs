namespace chocolatey.infrastructure.results
{
    using System.Linq;

    /// <summary>
    ///   Outcome of package installation
    /// </summary>
    public sealed class PackageResult : Result
    {
        public bool Inconclusive
        {
            get { return _messages.Value.Any(x => x.MessageType == ResultType.Inconclusive); }
        }

        public string Name { get; private set; }
        public string Version { get; private set; }
        public string InstallTopLevelLocation { get; set; }

        public PackageResult(string name, string version) : this(name,version,null)
        {}

        public PackageResult(string name, string version, string installTopLevelLocation)
        {
            Name = name;
            Version = version;
            InstallTopLevelLocation = installTopLevelLocation;
        }
    }
}