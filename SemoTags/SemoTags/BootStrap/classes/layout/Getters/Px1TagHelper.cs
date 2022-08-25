 
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Getters
{
    [HtmlTargetElement(Attributes = "px-1")]
    public class Px1TagHelper:TagHelper
    
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("px1");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", "px-1");
            else
                output.AddClass("px-1", HtmlEncoder.Default);
        }
        

    }
}
