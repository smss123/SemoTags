using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container")]
public class ContainerTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
 
        output.Attributes.RemoveAll("container");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "container");
        else
            output.AddClass("container", HtmlEncoder.Default);
    }
}