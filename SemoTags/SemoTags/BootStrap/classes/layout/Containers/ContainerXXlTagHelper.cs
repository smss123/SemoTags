using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-xxl")]
public class ContainerXXlTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
 
        output.Attributes.RemoveAll("container-xxl");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "container-xxl");
        else
            output.AddClass("container-xxl", HtmlEncoder.Default);
    }
}