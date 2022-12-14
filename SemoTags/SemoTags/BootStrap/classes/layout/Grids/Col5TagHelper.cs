using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col-5")]
public class Col5TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      
        output.Attributes.RemoveAll("col-5");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-5");
        else
            output.AddClass("col-5", HtmlEncoder.Default);
    }
}