using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.Bootstrap.Layout.Builders;
using SemoTags.Bootstrap.Layout.Options;

namespace SemoTags.Bootstrap.Layout;

public class ColTagHelper : TagHelper
{
    public BootStrapSize Size { get; set; } = BootStrapSize.Default;

    public bool Offset { get; set; } = false;


    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        ColumnTagBuilder builder = new ColumnTagBuilder();
        output.TagName = "div";
        BuildSize(ref builder);
        var content = await output.GetChildContentAsync();
        output.Content.SetHtmlContent(content);
        output.Attributes.Add("class", builder.Build());
    }




private void BuildSize(ref ColumnTagBuilder builder)
    {
        switch (Size)
        {
            case BootStrapSize.Default:
                builder.AddColumn();
                break;
            case BootStrapSize.Large:
                builder.AddLargeColumn();
                break;
            case BootStrapSize.Medium:
                builder.AddMediumColumn();
                break;
            case BootStrapSize.Small:
                builder.AddSmallColumn();
                break;
            case BootStrapSize.ExtraSmall:
                builder.AddExtraSmallColumn();
                break;
            default:
                builder.AddColumn();
                break;
        }



    }
}