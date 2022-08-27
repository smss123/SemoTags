using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-sm")]
public class ContainerSmTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
 
        output.Attributes.RemoveAll("container-sm");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "container-sm");
        else
            output.AddClass("container-sm", HtmlEncoder.Default);
    }
}