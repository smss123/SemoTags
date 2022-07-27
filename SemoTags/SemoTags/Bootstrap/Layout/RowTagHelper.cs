using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.Bootstrap.Layout;

public class RowTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.Add("class", "row");
        output.Content.SetHtmlContent(await output.GetChildContentAsync());
    }
}