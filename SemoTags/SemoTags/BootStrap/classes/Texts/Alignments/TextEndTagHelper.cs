using System.Text.Encodings.Web;

using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.Texts.Alignments;

[HtmlTargetElement(Attributes = "text-end")]
public class TextEndTagHelper :BaseTextTagHelper
{
   
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    { 
        BuildText(context, output, "end");
 
    }
}