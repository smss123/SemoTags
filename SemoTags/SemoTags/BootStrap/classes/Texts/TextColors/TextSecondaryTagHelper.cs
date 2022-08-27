using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextColors;

[HtmlTargetElement(Attributes = "text-secondary")]
public class TextSecondaryTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {

        output.Attributes.RemoveAll("text-secondary");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-secondary");
        else
            output.AddClass("text-secondary", HtmlEncoder.Default);
    }
}