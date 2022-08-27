using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-7")]
public class Col7TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
       
        output.Attributes.RemoveAll("col-7");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-7");
        else
            output.AddClass("col-7", HtmlEncoder.Default);
    }
}