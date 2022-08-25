using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container")]
public class ContainerTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("container");
        output.Attributes.Add("class", "container");
    }
}