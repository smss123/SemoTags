namespace SemoTags.Common;

public enum BootStrapSize
{
    Sm = 1,
    Md = 2,
    Lg = 3,
    Xl = 4,
    Xxl = 5,
    Fluid = 6,
    None = 7
}

public class BootStrapSizeBuilder
{
    public static string GetBootStrapSize(BootStrapSize size)
    {
        switch (size)
        {
            case BootStrapSize.Sm:
                return "-sm";
            case BootStrapSize.Md:
                return "-md";
            case BootStrapSize.Lg:
                return "-lg";
            case BootStrapSize.Xl:
                return "-xl";
            case BootStrapSize.Xxl:
                return "-xxl";
            case BootStrapSize.Fluid:
                return "-fluid";
            case BootStrapSize.None:
                return "";
            default:
                return "";
        }
    }
}