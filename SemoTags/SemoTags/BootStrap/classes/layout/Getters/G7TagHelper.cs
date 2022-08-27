using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g7")]
public class G7TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g7");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-7");
        else
            output.AddClass("g-7", HtmlEncoder.Default);
    }
}