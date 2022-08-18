using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemoTags.BootStrap.Components.Alerts;

namespace SemoTags.BootStrap.Components.Badges
{
    /// <summary>
    /// this Record is option of Positioned Badge 
    /// </summary>
    public record PositionedArg
    {
        public string? NotificationText { get; set; }
        public string? Href { get; set; }
        public ColorType InnerColor { get; set; }
        public string? VisuallyHidden { get; set; }
    }
}
