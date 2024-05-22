namespace RecordDTO.DTOs;

public class RegisterUserDTO
{
    public string Username { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; }
}