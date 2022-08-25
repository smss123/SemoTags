using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-md")]
public class ContainerMdTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
    

        output.Attributes.RemoveAll("container-md");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "container-md");
        else
            output.AddClass("container-md", HtmlEncoder.Default);
    }
}