using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy10")]
public class Gy10TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy10");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-10");
        else
            output.AddClass("gy-10", HtmlEncoder.Default);
    }
}