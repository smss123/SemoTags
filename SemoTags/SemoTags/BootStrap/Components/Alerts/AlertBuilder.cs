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

        public AlertBuilder SetAlertType(AlertType type)
        {
            switch (type)
            {
                case AlertType.Primary:
                    _html += "primary";
                    break;
                case AlertType.Secondary:
                    _html += "secondary";
                    break;
                case AlertType.Success:
                    _html += "success";
                    break;
                case AlertType.Danger:
                    _html += "danger";
                    break;
                case AlertType.Warning:
                    _html += "warning";
                    break;
                case AlertType.Info:
                    _html += "info";
                    break;
                case AlertType.Light:
                    _html += "light";
                    break;
                case AlertType.Dark:
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

        public string GetAlertType(AlertType type)
        {
            switch (type)
            {
                case AlertType.Primary:
                    return "primary";
                case AlertType.Secondary:
                    return "secondary";
                case AlertType.Success:
                    return "success";
                case AlertType.Danger:
                    return "danger";
                case AlertType.Warning:
                    return "warning";
                case AlertType.Info:
                    return "info";
                case AlertType.Light:
                    return "light";
                case AlertType.Dark:
                    return "dark";
            }

            return "primary";


        }

    }
}
