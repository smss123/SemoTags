using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-lg")]
public class ContainerLgTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("container-lg");
        output.Attributes.Add("class", "container-lg");
    }
}