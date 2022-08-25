using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-8")]
public class Col8TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
 
        output.Attributes.RemoveAll("col-8");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-8");
        else
            output.AddClass("col-8", HtmlEncoder.Default);
    }
}