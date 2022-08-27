using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g3")]
public class G3TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g3");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-3");
        else
            output.AddClass("g-3", HtmlEncoder.Default);
    }
}