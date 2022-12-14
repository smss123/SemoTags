 

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextBgs;

[HtmlTargetElement(Attributes = "text-bg-primary")]
public class TextBgPrimary:BaseTextTagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("text-bg-primary");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-bg-primary");
        else
            output.AddClass("text-bg-primary", HtmlEncoder.Default);
    }
}