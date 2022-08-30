using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.Links;

[HtmlTargetElement(Attributes = "link-warning")]
public class LinkWarningTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("link-warning");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "link-warning");
        else
            output.AddClass("link-warning", HtmlEncoder.Default);
    }
}