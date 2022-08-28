using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextBgs;

[HtmlTargetElement(Attributes = "text-bg-danger")]
public class TextBgDanger : BaseTextTagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("text-bg-danger");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-bg-danger");
        else
            output.AddClass("text-bg-danger", HtmlEncoder.Default);
    }
}


[HtmlTargetElement(Attributes = "text-bg-warning")]
public class TextBgWarning : BaseTextTagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("text-bg-warning");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-bg-warning");
        else
            output.AddClass("text-bg-warning", HtmlEncoder.Default);
    }
}