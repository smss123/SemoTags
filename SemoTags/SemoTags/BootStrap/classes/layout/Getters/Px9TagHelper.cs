using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "px-9")]
public class Px9TagHelper : TagHelper

{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("px9");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "px-9");
        else
            output.AddClass("px-9", HtmlEncoder.Default);
    }


}