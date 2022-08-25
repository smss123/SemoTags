using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-1")]
public class Col1TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-1");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-1");
        else
            output.AddClass("col-1", HtmlEncoder.Default);
    }
}