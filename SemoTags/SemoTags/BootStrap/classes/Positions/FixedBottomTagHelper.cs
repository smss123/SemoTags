using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Positions;

[HtmlTargetElement(Attributes = "fixed-bottom")]
public class FixedBottomTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("fixed-bottom");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "fixed-bottom");
        else
            output.AddClass("fixed-bottom", HtmlEncoder.Default);
    }
}