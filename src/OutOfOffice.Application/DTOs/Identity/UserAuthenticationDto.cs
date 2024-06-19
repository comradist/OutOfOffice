using System.ComponentModel.DataAnnotations;

namespace OutOfOffice.Application.DTOs.Identity;

public class UserAuthenticationDto
{
    public string UserNameOrEmail { get; set; }

    public string Password { get; set; }
}