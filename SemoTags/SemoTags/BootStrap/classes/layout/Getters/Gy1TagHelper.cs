 

using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.layout.Getters
{
    [HtmlTargetElement(Attributes = "gy1")]
    public class Gy1TagHelper:TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("gy1");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", "gy-1");
            else
                output.AddClass("gy-1", HtmlEncoder.Default);
        }
    }
}
