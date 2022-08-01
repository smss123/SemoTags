using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.Layout;

public class RowTagHelper : TagHelper
{
    public bool JustifyContentCenter { get; set; } = false;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        string className = "row";
        output.Attributes.Add("class", className);
        if (JustifyContentCenter)
        {
            className += " justify-content-center";
        }

        output.Content.SetHtmlContent(await output.GetChildContentAsync());
    }
}