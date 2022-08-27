using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextColors;

[HtmlTargetElement(Attributes = "text-danger")]
public class TextDangerTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {

        output.Attributes.RemoveAll("text-danger");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-danger");
        else
            output.AddClass("text-danger", HtmlEncoder.Default);
    }
}