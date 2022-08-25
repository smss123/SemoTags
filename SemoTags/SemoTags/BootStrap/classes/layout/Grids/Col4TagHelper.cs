using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-4")]
public class Col4TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-4");
        output.Attributes.Add("class", "col-4");
    }
}