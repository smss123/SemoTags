 
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.Alignments;

[HtmlTargetElement(Attributes = "text-start")]
public class TextStartTagHelper:BaseTextTagHelper
{
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        BuildText(context,output, "Start");
        
    }
}