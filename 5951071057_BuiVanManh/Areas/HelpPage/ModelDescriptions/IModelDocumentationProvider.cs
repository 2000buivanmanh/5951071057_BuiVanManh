using System;
using System.Reflection;

namespace _5951071057_BuiVanManh.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}