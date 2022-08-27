using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g10")]
public class G10TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g10");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-10");
        else
            output.AddClass("g-10", HtmlEncoder.Default);
    }
}