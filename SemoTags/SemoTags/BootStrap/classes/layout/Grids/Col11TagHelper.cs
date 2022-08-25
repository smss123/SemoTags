using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-11")]
public class Col11TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-11");
        output.Attributes.Add("class", "col-11");
    }
}