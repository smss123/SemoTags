using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.Common;

namespace SemoTags.BootStrap.Layout;

public class ColTagHelper : TagHelper
{
    public BootStrapSize Size { get; set; } = BootStrapSize.None;
    public ColumnSize ColumnSize { get; set; }
    public bool AlignSelfStart { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        var className = "col-";
        if (Size != BootStrapSize.None)
            className += Size.ToString().ToLower();
        if (ColumnSize != ColumnSize.None)
            className += "-" + ColumnSize.ToString();
        if (AlignSelfStart)
            className += " align-self-start";
        output.Attributes.Add("class", className);
    }
}