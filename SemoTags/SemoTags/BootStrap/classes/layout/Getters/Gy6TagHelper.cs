using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy6")]
public class Gy6TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy6");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-6");
        else
            output.AddClass("gy-6", HtmlEncoder.Default);
    }
}