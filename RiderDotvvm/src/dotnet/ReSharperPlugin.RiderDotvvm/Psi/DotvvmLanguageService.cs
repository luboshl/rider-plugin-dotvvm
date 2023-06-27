using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Html;
using JetBrains.ReSharper.Psi.Html.Parsing;

namespace ReSharperPlugin.DotvvmPlugin.Psi;

[Language(typeof(DotvvmLanguage))]
public class DotvvmLanguageService : HtmlLanguageService
{
    public DotvvmLanguageService(
        HtmlLanguage htmlLanguage,
        IConstantValueService constantValueService,
        IHtmlTokenNodeTypes tokenNodeTypes,
        IHtmlCodeFormatter codeFormatter,
        IWebTreeBuilderFactory webTreeBuilderFactory)
        : base(htmlLanguage, constantValueService, tokenNodeTypes, codeFormatter, webTreeBuilderFactory)
    {
    }
}