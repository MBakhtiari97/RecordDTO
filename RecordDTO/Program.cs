using RecordDTO;
using RecordDTO.DTOs;

public class Program
{
    public static void Main(string[] args)
    {
        var username = Console.ReadLine();
        var password = Console.ReadLine();
        var emailAddress = Console.ReadLine();

        //With Records
        var firstRegisterDetails = new RegisterUser(username, emailAddress, password, true);

        //With DTOs
        var secondRegisterDetails = new RegisterUserDTO()
        {
            EmailAddress = emailAddress,
            Password = password,
            RememberMe = true,
            Username = username,
        };

        RegisterService.DoRegisterWithRecords(firstRegisterDetails);
        RegisterService.DoRegisterWithDTOs(secondRegisterDetails);
    }
}