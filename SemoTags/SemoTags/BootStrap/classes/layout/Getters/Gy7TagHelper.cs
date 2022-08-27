using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy7")]
public class Gy7TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy7");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-7");
        else
            output.AddClass("gy-7", HtmlEncoder.Default);
    }
}