using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-6")]
public class Px6TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px6");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-6");
        else
            output.AddClass("px-6", HtmlEncoder.Default);
    }


}