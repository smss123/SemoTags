using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g9")]
public class G9TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g9");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-9");
        else
            output.AddClass("g-9", HtmlEncoder.Default);
    }
}