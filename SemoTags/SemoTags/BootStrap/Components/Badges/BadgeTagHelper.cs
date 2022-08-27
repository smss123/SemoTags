

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

using SemoTags.BootStrap.Components.Alerts;

namespace SemoTags.BootStrap.Components.Badges
{


    public class BadgeTagHelper : TagHelper
    {


        public ColorType Type { get; set; }
        public BadgePosition State { get; set; } = BadgePosition.Default;
        public string NotificationBadge { get; set; } = "";
        public PositionedArg PositionedOptions { get; set; }
        public string? Href { get; set; } = "";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var builder = new BadgeBuilder();
            switch (State)
            {
                case BadgePosition.Default:
                    builder.BuildDefault(output, Type);
                    break;
                case BadgePosition.Notification:
                    await builder.BuildNotification(output, Type, NotificationBadge);
                    break;
                case BadgePosition.Positioned:
                    await builder.BuildPositioned(output, Href, Type, PositionedOptions);
                    break;
                 
            }






        }
    }
}
