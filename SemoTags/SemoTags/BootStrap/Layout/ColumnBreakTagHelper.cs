using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.Layout;

public class ColumnBreakTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.SetAttribute("class", "w-100");
        output.Content.SetHtmlContent(await output.GetChildContentAsync());
    }
}