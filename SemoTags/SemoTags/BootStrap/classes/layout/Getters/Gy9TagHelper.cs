using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy9")]
public class Gy9TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy9");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-9");
        else
            output.AddClass("gy-9", HtmlEncoder.Default);
    }
}