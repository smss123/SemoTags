using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Semo.Tag.Web.Models;

public class XUser
{
    [DisplayName("User Name")] [Required] public string UserName { get; set; }
    public string Password { get; set; }
    public bool Check { get; set; }
    public int IntegerX { get; set; }
    public byte[] Bytes { get; set; }
}