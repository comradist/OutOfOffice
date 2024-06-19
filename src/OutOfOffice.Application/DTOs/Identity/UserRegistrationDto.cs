using System.ComponentModel.DataAnnotations;

namespace OutOfOffice.Application.DTOs.Identity;

public class UserRegistrationDto
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }
}