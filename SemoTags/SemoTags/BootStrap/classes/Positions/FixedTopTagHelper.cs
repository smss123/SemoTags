using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Positions;

[HtmlTargetElement(Attributes = "fixed-top")]
public class FixedTopTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("fixed-top");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "fixed-top");
        else
            output.AddClass("fixed-top", HtmlEncoder.Default);
    }
}