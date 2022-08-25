using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g2")]
public class G2TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g2");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-2");
        else
            output.AddClass("g-2", HtmlEncoder.Default);
    }
}