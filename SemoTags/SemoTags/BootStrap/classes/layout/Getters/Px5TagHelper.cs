using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-5")]
public class Px5TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px5");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-5");
        else
            output.AddClass("px-5", HtmlEncoder.Default);
    }


}