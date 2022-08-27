using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g1")]
public class G1TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g1");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-1");
        else
            output.AddClass("g-1", HtmlEncoder.Default);
    }
}