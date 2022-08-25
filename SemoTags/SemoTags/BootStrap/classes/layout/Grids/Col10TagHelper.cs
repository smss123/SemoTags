using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-10")]
public class Col10TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-10");
        output.Attributes.Add("class", "col-10");
    }
}