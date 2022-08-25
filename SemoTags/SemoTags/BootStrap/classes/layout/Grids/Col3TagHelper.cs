using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-3")]
public class Col3TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-3");
        output.Attributes.Add("class", "col-3");
    }
}