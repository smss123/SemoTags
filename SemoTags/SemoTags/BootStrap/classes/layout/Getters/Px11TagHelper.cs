using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-11")]
public class Px11TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px11");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-11");
        else
            output.AddClass("px-11", HtmlEncoder.Default);
    }


}