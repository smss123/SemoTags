using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-10")]
public class Px10TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px10");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-10");
        else
            output.AddClass("px-10", HtmlEncoder.Default);
    }


}