
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextColors;

[HtmlTargetElement(Attributes = "text-success")]
public class TextSuccessTagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {

        output.Attributes.RemoveAll("text-success");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-success");
        else
            output.AddClass("text-success", HtmlEncoder.Default);
    }
}