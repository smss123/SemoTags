using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-xxl")]
public class ContainerXXlTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("container-xxl");
        output.Attributes.Add("class", "container-xxl");
    }
}