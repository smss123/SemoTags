using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-9")]
public class Col9TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
       
        output.Attributes.RemoveAll("col-9");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-9");
        else
            output.AddClass("col-9", HtmlEncoder.Default);
    }
}