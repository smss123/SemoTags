using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-3")]
public class Px3TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px3");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-3");
        else
            output.AddClass("px-3", HtmlEncoder.Default);
    }


}