using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemoTags.BootStrap.Components.Alerts
{
    internal class AlertBuilder
    {
        private static string? _html;

        public AlertBuilder  BeginAlert()
        {
            _html = "<div class=\"alert alert-";
            return this;
        }

        public AlertBuilder SetAlertType(ColorType type)
        {
            switch (type)
            {
                case ColorType.Primary:
                    _html += "primary";
                    break;
                case ColorType.Secondary:
                    _html += "secondary";
                    break;
                case ColorType.Success:
                    _html += "success";
                    break;
                case ColorType.Danger:
                    _html += "danger";
                    break;
                case ColorType.Warning:
                    _html += "warning";
                    break;
                case ColorType.Info:
                    _html += "info";
                    break;
                case ColorType.Light:
                    _html += "light";
                    break;
                case ColorType.Dark:
                    _html += "dark";
                    break;
            }

            return this;
        }
        public AlertBuilder SetContent(string str)
        {
            _html += "\">" + str + "</div>";
            return this;
        }
        
        public AlertBuilder EndAlert()
        {
            _html += "\">";
            return this;
        }

        public string? Build()
        {
            return _html;
        }

        public string GetAlertType(ColorType type)
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
            }

            return "primary";


        }

    }
}
