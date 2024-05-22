namespace RecordDTO.DTOs;

public record RegisterUser(
        string Username,
        string EmailAddress,
        string Password,
        bool RememberMe
    );