using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.Bootstrap;

public class ContainerTagHelper:TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.Add("class", "container");
        output.Content.SetHtmlContent(await output.GetChildContentAsync());
    }
}