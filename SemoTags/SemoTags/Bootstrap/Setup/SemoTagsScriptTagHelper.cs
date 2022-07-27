using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace SemoTags.Bootstrap.Setup;

public class SemoTagsScriptTagHelper : ITagHelperInitializer<ScriptTagHelper>

{
    public void Initialize(ScriptTagHelper helper, ViewContext context)
    {
    }
}