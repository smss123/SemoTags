using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-10")]
public class Col10TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
  
        output.Attributes.RemoveAll("col-10");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-10");
        else
            output.AddClass("col-10", HtmlEncoder.Default);
    }
}