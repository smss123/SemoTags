using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy11")]
public class Gy11TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy11");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-11");
        else
            output.AddClass("gy-11", HtmlEncoder.Default);
    }
}