using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.Links;

[HtmlTargetElement(Attributes = "link-secondary")]
public class LinkSecondaryTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("link-secondary");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "link-secondary");
        else
            output.AddClass("link-secondary", HtmlEncoder.Default);
    }
}