 

using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.BootStrap.Components.Alerts;

namespace SemoTags.BootStrap.Components.Badges
{
    public class BadgeTagHelper:TagHelper
    {
        public ColorType Type { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var builder = new BadgeBuilder();
            output.Attributes.Add("class", $"badge badge-{builder.GetBadgeType(Type)}");
        }
    }

    public class BadgeBuilder
    {
        public string GetBadgeType(ColorType type)
        {
            switch (type)
            {

                case ColorType.Primary:
                    return "primary";
                case ColorType.Secondary:
                    return "secondary";
                case ColorType.Success:
                    return "success";
                case ColorType.Danger:
                    return "danger";
                case ColorType.Warning:
                    return "warning";
                case ColorType.Info:
                    return "info";
                case ColorType.Light:
                    return "light";
                case ColorType.Dark:
                    return "dark";
                default:
                    return "primary";
            }
        }
    }
}
