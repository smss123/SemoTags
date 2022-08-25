using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g6")]
public class G6TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g6");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-6");
        else
            output.AddClass("g-6", HtmlEncoder.Default);
    }
}