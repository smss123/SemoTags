using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextColors;

[HtmlTargetElement(Attributes = "text-light")]
public class TextLightTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {

        output.Attributes.RemoveAll("text-light");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-light");
        else
            output.AddClass("text-light", HtmlEncoder.Default);
    }
}