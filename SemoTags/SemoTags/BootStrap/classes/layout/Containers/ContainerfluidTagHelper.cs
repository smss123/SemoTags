using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Containers;

[HtmlTargetElement(Attributes = "container-fluid")]
public class ContainerFluidTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        
        output.Attributes.RemoveAll("container-fluid");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "container-fluid");
        else
            output.AddClass("container-fluid", HtmlEncoder.Default);
    }
}


