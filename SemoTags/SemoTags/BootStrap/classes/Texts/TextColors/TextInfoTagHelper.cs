using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextColors;

[HtmlTargetElement(Attributes = "text-info")]
public class TextInfoTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {

        output.Attributes.RemoveAll("text-info");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-info");
        else
            output.AddClass("text-info", HtmlEncoder.Default);
    }
}