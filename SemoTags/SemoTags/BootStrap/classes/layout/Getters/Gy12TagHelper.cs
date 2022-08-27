using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy12")]
public class Gy12TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy12");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-12");
        else
            output.AddClass("gy-12", HtmlEncoder.Default);
    }
}