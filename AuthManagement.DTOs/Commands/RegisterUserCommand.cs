using AuthManagement.DTOs.Responses;
using SalesManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthManagement.DTOs.Commands
{
    public class RegisterUserCommand: ICommand<RegisterResponseDto>
    {
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
