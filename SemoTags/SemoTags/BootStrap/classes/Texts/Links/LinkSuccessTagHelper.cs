using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.Links;

[HtmlTargetElement(Attributes = "link-success")]
public class LinkSuccessTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("link-success");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "link-success");
        else
            output.AddClass("link-success", HtmlEncoder.Default);
    }
}