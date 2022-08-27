using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy4")]
public class Gy4TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy4");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-4");
        else
            output.AddClass("gy-4", HtmlEncoder.Default);
    }
}