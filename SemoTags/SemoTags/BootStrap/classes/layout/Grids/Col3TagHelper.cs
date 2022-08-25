using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-3")]
public class Col3TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
 
        output.Attributes.RemoveAll("col-3");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-3");
        else
            output.AddClass("col-3", HtmlEncoder.Default);
    }
}