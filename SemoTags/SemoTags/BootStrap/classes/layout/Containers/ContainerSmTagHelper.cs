using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-sm")]
public class ContainerSmTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("container-sm");
        output.Attributes.Add("class", "container-sm");
    }
}