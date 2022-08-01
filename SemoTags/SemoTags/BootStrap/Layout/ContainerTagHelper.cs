using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.Common;

namespace SemoTags.BootStrap.Layout;

/// <summary>
/// Containers are the most basic layout element in Bootstrap and are required when using our default grid system. Containers are used to contain, pad, and (sometimes) center the content within them. While containers can be nested, most layouts do not require a nested container.
/// </summary>
public class ContainerTagHelper : TagHelper
{
    public BootStrapSize Size { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        string className = "container";
        className += BootStrapSizeBuilder.GetBootStrapSize(Size);
        output.Attributes.Add("class", className);
        output.Content.SetHtmlContent(await output.GetChildContentAsync());
    }
}