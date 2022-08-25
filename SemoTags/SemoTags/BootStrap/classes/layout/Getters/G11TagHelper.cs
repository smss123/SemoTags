using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g11")]
public class G11TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g11");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-11");
        else
            output.AddClass("g-11", HtmlEncoder.Default);
    }
}