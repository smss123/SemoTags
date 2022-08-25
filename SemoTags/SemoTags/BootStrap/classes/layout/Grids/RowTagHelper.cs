using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.classes.layout.Grids
{
    [HtmlTargetElement(Attributes = "row")]
    public class RowTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("row");
            if (!output.Attributes.Any(p => p.Name == "class"))
                output.Attributes.Add("class", "row");
            else
           output.AddClass("row",HtmlEncoder.Default);

           
        }
    }
}