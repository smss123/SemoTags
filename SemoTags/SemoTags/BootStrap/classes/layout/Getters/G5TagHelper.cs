using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g5")]
public class G5TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g5");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-5");
        else
            output.AddClass("g-5", HtmlEncoder.Default);
    }
}