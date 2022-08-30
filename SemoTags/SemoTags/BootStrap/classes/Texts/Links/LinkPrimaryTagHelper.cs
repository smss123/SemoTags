 

using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.Texts.Links;

[HtmlTargetElement(Attributes = "link-primary")]
public class LinkPrimaryTagHelper:TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("link-primary");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "link-primary");
        else
            output.AddClass("link-primary", HtmlEncoder.Default);
    }
}