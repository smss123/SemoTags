using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-11")]
public class Col11TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
     
        output.Attributes.RemoveAll("col-11");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-11");
        else
            output.AddClass("col-11", HtmlEncoder.Default);
    }
}