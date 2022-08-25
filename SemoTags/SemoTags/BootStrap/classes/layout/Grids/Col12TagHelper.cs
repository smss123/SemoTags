using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-12")]
public class Col12TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-12");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-12");
        else
            output.AddClass("col-12", HtmlEncoder.Default);
    }
}