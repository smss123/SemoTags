using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "col-2")]
public class Col2TagHelper : TagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("col-2");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "col-2");
        else
            output.AddClass("col-2", HtmlEncoder.Default);
    }
}