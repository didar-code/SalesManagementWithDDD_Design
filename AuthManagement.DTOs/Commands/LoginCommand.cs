using AuthManagement.DTOs.Responses;
using SalesManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AuthManagement.DTOs.Commands
{
    public class LoginCommand:ICommand<LoginResponseDto>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }= string.Empty;
    }
}
