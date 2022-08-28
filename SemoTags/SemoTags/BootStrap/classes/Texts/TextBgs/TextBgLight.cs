using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextBgs;

[HtmlTargetElement(Attributes = "text-bg-light")]
public class TextBgLight : BaseTextTagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("text-bg-light");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-bg-light");
        else
            output.AddClass("text-bg-light", HtmlEncoder.Default);
    }
}