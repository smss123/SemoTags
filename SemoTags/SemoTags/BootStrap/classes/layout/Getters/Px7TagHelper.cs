using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-7")]
public class Px7TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px7");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-7");
        else
            output.AddClass("px-7", HtmlEncoder.Default);
    }


}