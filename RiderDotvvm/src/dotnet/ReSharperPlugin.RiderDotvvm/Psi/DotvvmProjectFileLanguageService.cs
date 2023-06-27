using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Angular2Html;
using JetBrains.ReSharper.Psi.Html;
using ReSharperPlugin.RiderDotvvm.ProjectModel;

namespace ReSharperPlugin.DotvvmPlugin.Psi;

[ProjectFileType(typeof(DotvvmProjectFileType))]
public class DotvvmProjectFileLanguageService : HtmlProjectFileLanguageService
{
    protected override PsiLanguageType PsiLanguageType => (PsiLanguageType) DotvvmLanguage.Instance ?? UnknownLanguage.Instance;

    public DotvvmProjectFileLanguageService(
        HtmlProjectFileType projectFileType,
        AngularIsEnabledProvider angularIsEnabledProvider,
        HtmlPsiPropertiesProvider htmlPsiPropertiesProvider)
        : base(projectFileType, angularIsEnabledProvider, htmlPsiPropertiesProvider)
    {
    }

    protected DotvvmProjectFileLanguageService(HtmlProjectFileType projectFileType) : base(projectFileType)
    {
    }
}