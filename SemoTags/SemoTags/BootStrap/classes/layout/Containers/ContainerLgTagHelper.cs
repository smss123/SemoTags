using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-lg")]
public class ContainerLgTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        
        output.Attributes.RemoveAll("container-lg");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "container-lg");
        else
            output.AddClass("container-lg", HtmlEncoder.Default);
    }
}