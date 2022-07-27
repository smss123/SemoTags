using SemoTags.Bootstrap;

namespace SemoTags.Common;

public class SizeFactory
{
    public static string GetSize(ContainerTagHelper.CSize size)
    {
        switch (size)
        {
            case ContainerTagHelper.CSize.Large:
                return "-lg";
            case ContainerTagHelper.CSize.Medium:
                return "-md";
            case ContainerTagHelper.CSize.Small:
                return "-sm";
            case ContainerTagHelper.CSize.ExtraSmall:
                return "-xs";
            default:
                return "";
        }
    }
}