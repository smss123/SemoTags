using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextBgs;

[HtmlTargetElement(Attributes = "text-bg-success ")]
public class TextBgSuccess : BaseTextTagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("text-bg-success");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-bg-success");
        else
            output.AddClass("text-bg-success", HtmlEncoder.Default);
    }
}