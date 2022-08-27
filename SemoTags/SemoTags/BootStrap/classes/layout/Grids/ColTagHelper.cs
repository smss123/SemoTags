using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids;

[HtmlTargetElement(Attributes = "col")]
public class ColTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
       

        output.Attributes.RemoveAll("col");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col");
        else
            output.AddClass("col", HtmlEncoder.Default);
    }
}