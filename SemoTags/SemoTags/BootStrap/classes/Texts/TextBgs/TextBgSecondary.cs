using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.TextBgs;

[HtmlTargetElement(Attributes = "text-bg-secondary")]
public class TextBgSecondary : BaseTextTagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Attributes.RemoveAll("text-bg-secondary ");
        if (output.Attributes.All(p => p.Name != "class"))
            output.Attributes.Add("class", "text-bg-secondary ");
        else
            output.AddClass("text-bg-secondary ", HtmlEncoder.Default);
    }
}