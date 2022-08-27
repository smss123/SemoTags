 

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids
{
    [HtmlTargetElement(Attributes = "grid")]
    public class GridTagHelper:TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("grid");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", "grid");
            else
                output.AddClass("grid", HtmlEncoder.Default);
        }
    }
    
}
