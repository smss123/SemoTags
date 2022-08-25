using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-2")]
public class Px2TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px2");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-2");
        else
            output.AddClass("px-2", HtmlEncoder.Default);
    }


}