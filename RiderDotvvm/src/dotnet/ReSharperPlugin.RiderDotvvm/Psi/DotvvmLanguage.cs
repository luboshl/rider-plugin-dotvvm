using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Html;

namespace ReSharperPlugin.DotvvmPlugin.Psi;

[LanguageDefinition(Name)]
public class DotvvmLanguage : HtmlLanguage
{
    // Must be "new" as it overrides a public field in the base
    public new const string Name = "DOTVVM";

    // May need "new" if inheriting from another language, such as HTML
    // This value might be null, if the language has been disabled in Options
    [CanBeNull]
    [UsedImplicitly]
    public new static DotvvmLanguage Instance { get; private set; }


    private DotvvmLanguage() : base(Name, "DotVVM")
    {
    }

    protected DotvvmLanguage([NotNull] string name) : base(name)
    {
    }

    protected DotvvmLanguage([NotNull] string name, [NotNull] string presentableName) : base(name, presentableName)
    {
    }
}