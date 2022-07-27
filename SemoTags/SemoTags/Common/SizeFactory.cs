using SemoTags.Bootstrap;
using SemoTags.Bootstrap.Layout.Options;
using ContainerTagHelper = SemoTags.Bootstrap.Layout.Options.ContainerTagHelper;

namespace SemoTags.Common;

public class SizeFactory
{
    public static string GetSize(CSize size)
    {
        switch (size)
        {
            case CSize.Large:
                return "-lg";
            case CSize.Medium:
                return "-md";
            case CSize.Small:
                return "-sm";
            case CSize.ExtraSmall:
                return "-xs";
            default:
                return "";
        }
    }
}