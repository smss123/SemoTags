using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "gy5")]
public class Gy5TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("gy5");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "gy-5");
        else
            output.AddClass("gy-5", HtmlEncoder.Default);
    }
}