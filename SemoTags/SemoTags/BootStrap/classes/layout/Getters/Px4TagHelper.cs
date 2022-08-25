using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-4")]
public class Px4TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px4");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-4");
        else
            output.AddClass("px-4", HtmlEncoder.Default);
    }


}