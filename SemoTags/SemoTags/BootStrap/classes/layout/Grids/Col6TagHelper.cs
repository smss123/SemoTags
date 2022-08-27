using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-6")]
public class Col6TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      
        output.Attributes.RemoveAll("col-6");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-6");
        else
            output.AddClass("col-6", HtmlEncoder.Default);
    }
}