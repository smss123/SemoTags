using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-xl")]
public class ContainerXlTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("container-xl");
        output.Attributes.Add("class", "container-xl");
    }
}