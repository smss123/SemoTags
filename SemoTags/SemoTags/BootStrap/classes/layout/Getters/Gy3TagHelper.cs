using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy3")]
public class Gy3TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy3");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-3");
        else
            output.AddClass("gy-3", HtmlEncoder.Default);
    }
}