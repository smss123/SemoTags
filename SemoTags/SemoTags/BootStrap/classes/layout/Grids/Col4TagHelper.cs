using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-4")]
public class Col4TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
       
        output.Attributes.RemoveAll("col-4");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-4");
        else
            output.AddClass("col-4", HtmlEncoder.Default);
    }
}