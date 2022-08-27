using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-8")]
public class Px8TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px8");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-8");
        else
            output.AddClass("px-8", HtmlEncoder.Default);
    }


}