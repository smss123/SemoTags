using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy8")]
public class Gy8TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy8");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-8");
        else
            output.AddClass("gy-8", HtmlEncoder.Default);
    }
}