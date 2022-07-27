using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.Bootstrap.Layout.Options;

namespace SemoTags.Bootstrap.Layout;

public class ColTagHelper : TagHelper
{
    public BootStrapSize Size { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.Add("class", "col-" + Size.ToString());

        output.Attributes.Add("class", "col-md-12");
    }
}