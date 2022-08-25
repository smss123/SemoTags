using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters;

[HtmlTargetElement(Attributes = "g4")]
public class G4TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("g4");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "g-4");
        else
            output.AddClass("g-4", HtmlEncoder.Default);
    }
}