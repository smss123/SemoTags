using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy2")]
public class Gy2TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy2");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-2");
        else
            output.AddClass("gy-2", HtmlEncoder.Default);
    }
}