using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.Links;

[HtmlTargetElement(Attributes = "link-danger")]
public class LinkDangerTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("link-danger");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "link-danger");
        else
            output.AddClass("link-danger", HtmlEncoder.Default);
    }
}