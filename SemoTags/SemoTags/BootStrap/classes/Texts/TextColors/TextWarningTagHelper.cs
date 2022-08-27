using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextColors;

[HtmlTargetElement(Attributes = "text-warning")]
public class TextWarningTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {

        output.Attributes.RemoveAll("text-warning");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-warning");
        else
            output.AddClass("text-warning", HtmlEncoder.Default);
    }
}