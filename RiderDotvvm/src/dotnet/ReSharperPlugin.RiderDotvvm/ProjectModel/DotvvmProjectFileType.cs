using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.ProjectModel;

namespace ReSharperPlugin.RiderDotvvm.ProjectModel;

[ProjectFileTypeDefinition(Name)]
public class DotvvmProjectFileType : HtmlProjectFileType
{
    private const string DothtmlExtension = ".dothtml";
    private const string DotmasterExtension = ".dotmaster";

    // These need to be "new" as they are also defined in the base class
    public new const string Name = "DOTVVM";

    [CanBeNull]
    [UsedImplicitly]
    public new static DotvvmProjectFileType Instance { get; private set; }

    private DotvvmProjectFileType() : base(Name, "DotVVM", new[] {DothtmlExtension, DotmasterExtension})
    {
    }

    protected DotvvmProjectFileType(string name) : base(name)
    {
    }

    protected DotvvmProjectFileType(string name, string presentableName) : base(name, presentableName)
    {
    }

    protected DotvvmProjectFileType(string name, string presentableName, IEnumerable<string> extensions) : base(name,
        presentableName, extensions)
    {
    }
}