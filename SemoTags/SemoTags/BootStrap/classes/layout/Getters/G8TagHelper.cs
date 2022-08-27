using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g8")]
public class G8TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g8");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-8");
        else
            output.AddClass("g-8", HtmlEncoder.Default);
    }
}