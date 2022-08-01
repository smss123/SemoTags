namespace SemoTags.Common;

public class BootStrapSize
{
    public const string Sm = "sm";
    public const string Md = "md";
    public const string Lg = "lg";
    public const string Xl = "xl";

    public static string Bind(string size)
    {
        switch (size)
        {
            case "sm":
                return "small";
            case "md":
                return "medium";
            case "lg":
                return "large";
            case "xl":
                return "xlarge";
            default:
                return "medium";
        }
    }
}