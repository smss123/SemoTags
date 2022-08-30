using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Positions;

[HtmlTargetElement(Attributes = "sticky-top")]
public class StickyTopTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("sticky-top");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "sticky-top");
        else
            output.AddClass("sticky-top", HtmlEncoder.Default);
    }
}


 